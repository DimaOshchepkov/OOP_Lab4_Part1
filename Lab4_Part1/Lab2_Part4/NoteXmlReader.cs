using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace Lab2_Part4
{
    class NoteXmlReader : INoteReader
    {
        bool INoteReader.Read(string fileName, ref List<Note> PhoneNote)
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
            catch (Exception)
            {
                MessageBox.Show("xml файла не существуе");
                return false;
            }
        }
    }
}
