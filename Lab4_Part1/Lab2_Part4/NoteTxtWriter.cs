using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab2_Part4
{
    class NoteTxtWriter : INoteWriter
    {
        bool INoteWriter.Write(List<Note> PhoneNote, string fileName)
        {


            try         // обработчик исключительных ситуаций
            {
                // используя sw (экземпляр класса StreamWriter),
                // создаем файл с заданным в диалоговом окне именем
                using (StreamWriter sw = new StreamWriter(fileName))
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
                return true;
            }
            catch (Exception ex)    // перехватываем ошибку
            {
                // выводим информацию об ошибке
                MessageBox.Show("Не удалось сохранить данные! Ошибка: " +
                ex.Message);
                return false;
            }
        }


    }
}
