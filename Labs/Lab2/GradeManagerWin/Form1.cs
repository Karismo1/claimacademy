using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManagerWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {

        }

        public string ReturnFirstName()
        {
            return FirstNameTextBox.Text;
        }

        public string ReturnLastName()
        {
            return LastNameTextBox.Text;
        }
    }
}
