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
    public partial class SearchNameForm : Form
    {
        List<Note> PhoneNote;
        public SearchNameForm(List<Note> _PhoneNote)
        {
            InitializeComponent();
            PhoneNote = _PhoneNote;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // очищаем окно для вывода результатов
            ResultsTextBox.Text = "";
            // количество найденных результатов
            int i = 0;
            // цикл for для каждого элемента списка - foreach
            foreach (Note MyRecord in PhoneNote)
            {
                // если выполняются условия поиска
                if (MyRecord.LastName.Contains(LastNameTextBox.Text) &&
                MyRecord.Name.Contains(NameTextBox.Text) && MyRecord.Patronymic.Contains(PatronymicTextBox.Text))
                {
                    // увеличиваем счетчик найденных записей
                    i++;
                    // дописываем элемент и его номер к результату 
                    ResultsTextBox.Text = ResultsTextBox.Text + i.ToString() + ". " +
                            MyRecord.LastName + " " + MyRecord.Name + " " + MyRecord.Patronymic +
                            ", ул. " + MyRecord.Street + ", д." + MyRecord.House + ", кв. " +
                            MyRecord.Flat + ", тел. " + MyRecord.Phone + "\r\n";
                }
            }
            // если не найдено ни одной записи, выводим сообщение
            if (i == 0)
                ResultsTextBox.Text = "Записей, удовлетворяющих поставленным условиям, в списке абонентов нет! "; 

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
