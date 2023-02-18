using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Part4
{
    public partial class MainForm : Form
    {
        private List<Note> PhoneNote;
        private int current;
        public MainForm()
        {
            InitializeComponent();
            PhoneNote = new List<Note>();
            current = -1;

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

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // создаем запись - экземпляр класса Note
            Note MyRecord = new Note();

            // создаем экземпляр формы AddForm
            AddForm _AddForm = new AddForm(MyRecord);

            // открываем форму для добавления записи
            _AddForm.ShowDialog();

            // текущей записью становится последняя
            current = PhoneNote.Count;

            // добавляем к списку PhoneNote новый элемент - запись MyRecord,
            // взятую из формы AddForm
            PhoneNote.Add(_AddForm.MyRecord);

            // выводим текущий элемент
            PrintElement();

        }
    }
}
