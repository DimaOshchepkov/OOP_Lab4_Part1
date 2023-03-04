using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab2_Part4
{
    class NoteXmlWriter : INoteWriter
    {
        bool INoteWriter.Write(List<Note> PhoneNote, string fileName)
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
                return true;

            }
            catch (Exception ex)    // перехватываем ошибку
            {
                // выводим информацию об ошибке
                MessageBox.Show("Не удалось сохранить данные! Ошибка: " + ex.Message);

                return false;
            }
        }
    }
}
