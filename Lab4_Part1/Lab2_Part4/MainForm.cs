using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Lab2_Part4
{
    public partial class MainForm : Form
    {
        private List<Note> PhoneNote;
        private int current;
        private bool isSave;
        public MainForm()
        {
            InitializeComponent();
            PhoneNote = new List<Note>();
            current = -1;
            isSave = true;
        }

        private void PrintElement()
        {
            if ((current >= 0) && (current < PhoneNote.Count))
            {   // если есть что выводить
                // MyRecord - запись списка PhoneNote номер current
                Note MyRecord = PhoneNote[current];
                // записываем в соответствующие элементы на форме 
                // поля из записи MyRecord 
                LastNameTextBox.Text = MyRecord.LastName;
                NameTextBox.Text = MyRecord.Name;
                PatronymicTextBox.Text = MyRecord.Patronymic;
                PhoneMaskedTextBox.Text = MyRecord.Phone;
                StreetTextBox.Text = MyRecord.Street;
                HouseNumericUpDown.Value = MyRecord.House;
                FlatNumericUpDown.Value = MyRecord.Flat;
            }
            else // если current равно -1, т. е. список пуст
            {   // очистить поля формы 
                LastNameTextBox.Text = "";
                NameTextBox.Text = "";
                PatronymicTextBox.Text = "";
                PhoneMaskedTextBox.Text = "";
                StreetTextBox.Text = "";
                HouseNumericUpDown.Value = 1;
                FlatNumericUpDown.Value = 1;
            }
            // обновление строки состояния
            NumberToolStripStatusLabel.Text = (current + 1).ToString();
            QuantityToolStripStatusLabel.Text = PhoneNote.Count.ToString();
        }

        private bool isNoteOK(Note note)
        {
            if (HouseNumericUpDown.Minimum > note.House || note.House > HouseNumericUpDown.Maximum)
            {
                MessageBox.Show("Недопустимый номер дома");
                return false;
            }
            else if (FlatNumericUpDown.Minimum > note.Flat || note.Flat > FlatNumericUpDown.Maximum)
            {
                MessageBox.Show("Недопустимый номер квартиры");
                return false;
            }
            else if (PhoneNote.Any(x => x.Equals(note)))
            {
                MessageBox.Show("Абонент уже есть в телефонной книге");
                return false;
            }
            return true;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // создаем запись - экземпляр класса Note
            Note MyRecord = new Note();

            // создаем экземпляр формы AddForm
            AddForm _AddForm = new AddForm(MyRecord);

            // открываем форму для добавления записи
            _AddForm.ShowDialog();

            // добавляем к списку PhoneNote новый элемент - запись MyRecord,
            // взятую из формы AddForm

            if (isNoteOK((_AddForm.MyRecord)))
            {
                PhoneNote.Add(_AddForm.MyRecord);
                // текущей записью становится последняя
                current = PhoneNote.Count - 1;
                isSave = false;
            }

            // выводим текущий элемент
            PrintElement();


        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (current <= -1)
            {
                MessageBox.Show("Предыдущей записи не существует");
                return;
            }
            current--;      // уменьшаем номер текущей записи на 1
            PrintElement();

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (current >= PhoneNote.Count - 1)
            {
                MessageBox.Show("Следующей записи не существует");
                return;
            }
            current++;      // увеличиваем номер текущей записи на 1
            PrintElement();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            // Если в диалоговом окне нажали ОК
            {
                INoteWriter noteWriter;
                string fileName = saveFileDialog1.FileName;
                if (fileName.EndsWith(".txt"))
                {
                    noteWriter = new NoteTxtWriter();
                    isSave = noteWriter.Write(PhoneNote, fileName);
                }
                else if (fileName.EndsWith(".xml"))
                {
                    noteWriter = new NoteXmlWriter();
                    isSave = noteWriter.Write(PhoneNote, fileName);
                }
            }

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            // если в диалоговом окне нажали ОК
            {
                string fileName = openFileDialog1.FileName;
                INoteReader noteReader;
                if (fileName.EndsWith(".txt"))
                    {
                    noteReader = new NoteTxtReader();
                    if (noteReader.Read(fileName, ref PhoneNote))
                    {
                        // если список пуст, то current устанавливаем в -1,
                        // иначе текущей является первая с начала запись (номер 0)
                        if (PhoneNote.Count == 0) current = -1;
                        else current = 0;
                        // выводим текущий элемент
                        PrintElement();
                    }
                }
                else if (fileName.EndsWith(".xml"))
                {
                    noteReader = new NoteXmlReader();
                    if (noteReader.Read(fileName, ref PhoneNote))
                    {
                        if (PhoneNote.Count == 0) current = -1;
                        else current = 0;
                        PrintElement();
                    }
                }
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSave)
            {
                CloseForm closeForm = new CloseForm();
                closeForm.ShowDialog();
                if (closeForm.Answer == "Yes")
                    SaveToolStripMenuItem_Click(sender, e);
                if (closeForm.Answer == "Yes" && !isSave)
                    MainForm_FormClosing(sender, e);
                if (closeForm.Answer == "Cancel")
                    e.Cancel = true;
            }

        }
    }
}
