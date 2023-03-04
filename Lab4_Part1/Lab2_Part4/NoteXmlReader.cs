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
        List<Note> INoteReader.Read(string fileName)
        {
            List<Note> PhoneNote = new List<Note>();
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

                return PhoneNote;
            }
            catch (Exception)
            {
                MessageBox.Show("xml файла не существуе");
                return null;
            }
        }
    }
}
