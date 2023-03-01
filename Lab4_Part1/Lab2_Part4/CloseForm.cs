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
    public partial class CloseForm : Form
    {
        public String Answer { get; private set; }
        public CloseForm()
        {
            InitializeComponent();
            Answer = "Cancel";
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Answer = "Yes";
            Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Answer= "No";
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Answer = "Cancel";
            Close();
        }

    }
}
