using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Part4
{
    public class Note
    {
        public string LastName;
        public string Name;
        public string Patronymic;
        public string Street;
        public ushort House;
        public ushort Flat;
        public string Phone;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Note point = (Note)obj;
            return LastName == point.LastName && Name == point.Name &&
                Patronymic == point.Patronymic && Street == point.Street &&
                House == point.House &&  Phone == point.Phone;
        }
    }

}
