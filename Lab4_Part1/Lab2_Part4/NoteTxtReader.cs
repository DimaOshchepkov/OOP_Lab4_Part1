using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Lab2_Part4
{
    class NoteTxtReader : INoteReader
    {
        bool INoteReader.Read(string fileName, ref List<Note> PhoneNote)
        {
            try         // обработчик исключительных ситуаций
            {
                // считываем из указанного в диалоговом окне файла
                using (StreamReader sr =
                new StreamReader(fileName))
                {
                    // пока не дошли до конца файла
                    while (!sr.EndOfStream)
                    {
                        //выделяем место под запись
                        Note MyRecord = new Note();
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
                return true;
                /*
                // если список пуст, то current устанавливаем в -1,
                // иначе текущей является первая с начала запись (номер 0)
                if (PhoneNote.Count == 0) current = -1;
                else current = 0;
                // выводим текущий элемент
                PrintElement();
                */
            }
            catch (Exception ex)    // если произошла ошибка
            {
                // выводим сообщение об ошибке
                MessageBox.Show("При открытии файла произошла ошибка: " +
                ex.Message);
                return false;
            }
        }

    }

}
