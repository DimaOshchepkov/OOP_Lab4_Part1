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
                string fileName = saveFileDialog1.FileName;
                if (fileName.EndsWith(".txt"))
                {
                    try         // обработчик исключительных ситуаций
                    {
                        // используя sw (экземпляр класса StreamWriter),
                        // создаем файл с заданным в диалоговом окне именем
                        using (StreamWriter sw =
                        new StreamWriter(saveFileDialog1.FileName))
                        {
                            // проходим по всем элементам списка
                            foreach (Note MyRecord in PhoneNote)
                            {
                                // записываем каждое поле в отдельной строке
                                sw.WriteLine(MyRecord.LastName);
                                sw.WriteLine(MyRecord.Name);
                                sw.WriteLine(MyRecord.Patronymic);
                                sw.WriteLine(MyRecord.Street);
                                sw.WriteLine(MyRecord.House);
                                sw.WriteLine(MyRecord.Flat);
                                sw.WriteLine(MyRecord.Phone);
                            }
                        }
                        isSave = true;
                    }
                    catch (Exception ex)    // перехватываем ошибку
                    {
                        // выводим информацию об ошибке
                        MessageBox.Show("Не удалось сохранить данные! Ошибка: " +
                        ex.Message);
                    }
                }
                else if (fileName.EndsWith(".xml"))
                {
                    try
                    {

                        //создание xml документа со строкой <?xml version="1.0" encoding="utf-8"?>
                        XmlTextWriter textWritter = new XmlTextWriter(fileName, Encoding.UTF8);
                        textWritter.WriteStartDocument();//запись заголовка документа
                        textWritter.WriteStartElement("Notes");//создание головы
                        textWritter.WriteEndElement();//закрываем голову
                        textWritter.Close();//закрываем документ


                        XmlDocument document = new XmlDocument();//открываем документ  
                        document.Load(fileName);//загружаем из xml файла

                        int i = 0;
                        foreach (Note x in PhoneNote)
                        {
                            #region Записываем в XML все Note

                            /// <summary>
                            /// Создаём XML-запись
                            /// </summary>
                            XmlElement element = document.CreateElement("Note");
                            document.DocumentElement.AppendChild(element); // указываем родителя
                            XmlAttribute attribute = document.CreateAttribute("id"); // создаём атрибут
                            attribute.Value = i.ToString(); // устанавливаем значение атрибута
                            element.Attributes.Append(attribute); // добавляем атрибут


                            // Добавляем в запись данные
                            XmlNode lastnameElem = document.CreateElement("Lastname"); // даём имя
                            lastnameElem.InnerText = x.LastName; // и значение
                            element.AppendChild(lastnameElem); // и указываем кому принадлежит


                            XmlNode nameElem = document.CreateElement("Name");
                            nameElem.InnerText = x.Name;
                            element.AppendChild(nameElem);


                            XmlNode patronimicElem = document.CreateElement("Patronimic");
                            patronimicElem.InnerText = x.Patronymic;
                            element.AppendChild(patronimicElem);


                            XmlNode streetElem = document.CreateElement("street");
                            streetElem.InnerText = x.Street;
                            element.AppendChild(streetElem);


                            XmlNode houseElem = document.CreateElement("House");
                            houseElem.InnerText = x.House.ToString();
                            element.AppendChild(houseElem);


                            XmlNode flatElem = document.CreateElement("Flat");
                            flatElem.InnerText = x.Flat.ToString();
                            element.AppendChild(flatElem);


                            XmlNode phoneElem = document.CreateElement("Phone");
                            phoneElem.InnerText = x.Phone.ToString();
                            element.AppendChild(phoneElem);

                            i++;
                            #endregion
                        }

                        document.Save(fileName);
                        isSave = true;

                    }
                    catch (Exception ex)    // перехватываем ошибку
                    {
                        // выводим информацию об ошибке
                        MessageBox.Show("Не удалось сохранить данные! Ошибка: " + ex.Message);
                    }
                }
            }

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note MyRecord;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            // если в диалоговом окне нажали ОК
            {
                string fileName = openFileDialog1.FileName;
                if (fileName.EndsWith(".txt"))
                    {
                    try         // обработчик исключительных ситуаций
                    {
                        // считываем из указанного в диалоговом окне файла
                        using (StreamReader sr =
                        new StreamReader(openFileDialog1.FileName))
                        {
                            // пока не дошли до конца файла
                            while (!sr.EndOfStream)
                            {
                                //выделяем место под запись
                                MyRecord = new Note();
                                // считываем значения полей записи из файла
                                MyRecord.LastName = sr.ReadLine();
                                MyRecord.Name = sr.ReadLine();
                                MyRecord.Patronymic = sr.ReadLine();
                                MyRecord.Street = sr.ReadLine();
                                MyRecord.House = ushort.Parse(sr.ReadLine());
                                MyRecord.Flat = ushort.Parse(sr.ReadLine());
                                MyRecord.Phone = sr.ReadLine();
                                //добавляем запись в список
                                PhoneNote.Add(MyRecord);
                            }
                        }
                        // если список пуст, то current устанавливаем в -1,
                        // иначе текущей является первая с начала запись (номер 0)
                        if (PhoneNote.Count == 0) current = -1;
                        else current = 0;
                        // выводим текущий элемент
                        PrintElement();
                    }
                    catch (Exception ex)    // если произошла ошибка
                    {
                        // выводим сообщение об ошибке
                        MessageBox.Show("При открытии файла произошла ошибка: " +
                        ex.Message);
                    }
                }
                else if (fileName.EndsWith(".xml"))
                {
                    try
                    {
                        XmlDocument xDoc = new XmlDocument();
                        xDoc.Load(fileName);
                        XmlElement xRoot = xDoc.DocumentElement;
                        foreach (XmlElement xnode in xRoot)
                        {
                            Note node = new Note();
                            foreach (XmlNode cnode in xnode.ChildNodes)
                            {
                                if (cnode.Name == "Lastname") node.LastName = cnode.InnerText;
                                else if (cnode.Name == "Name") node.Name = cnode.InnerText;
                                else if (cnode.Name == "Patronimic") node.Patronymic = cnode.InnerText;
                                else if (cnode.Name == "Street") node.Street = cnode.InnerText;
                                else if (cnode.Name == "House") node.House = ushort.Parse(cnode.InnerText);
                                else if (cnode.Name == "Flat") node.Flat = ushort.Parse(cnode.InnerText);
                                else if (cnode.Name == "Phone") node.Phone = cnode.InnerText;
                            }
                            PhoneNote.Add(node);
 
                        }
                        // если список пуст, то current устанавливаем в -1,
                        // иначе текущей является первая с начала запись (номер 0)
                        if (PhoneNote.Count == 0) current = -1;
                        else current = 0;
                        // выводим текущий элемент
                        PrintElement();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("xml файла не существуе");
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
