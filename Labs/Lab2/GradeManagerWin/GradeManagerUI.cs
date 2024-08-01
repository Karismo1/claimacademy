using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManagerWin
{
    public partial class GradeManagerUI : Form
    {
        List<Student> students;
        public GradeManagerUI()
        {
            InitializeComponent();
        }

        private void GradeManagerUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadStudentFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog LoadStudentFileDiolog = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Load Student File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "JSON files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };

            if (LoadStudentFileDiolog.ShowDialog() == DialogResult.OK)
            {
                var jsonFile = LoadStudentFileDiolog.FileName;
                var json = File.ReadAllText(jsonFile);
                students = JsonConvert.DeserializeObject<List<Student>>(json);

                if (students != null)
                {
                    var message = $"Students loaded successfully. There are {students.Count} students currently.";
                    var caption = "Students loaded successfully";
                    MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

                else
                {
                    var message = "Loading students failed";
                    var caption = "Student Load Failed";
                    MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            var addStudentControl = new AddStudent();
            addStudentControl.Show();
            addStudentControl.Focus();
            var newStudentFirstName = addStudentControl.ReturnFirstName();
            var newStudentLastName = addStudentControl.ReturnLastName();
            var student = new Student(newStudentFirstName, newStudentLastName);
            students.Add(student);
            var messageBoxMessage = $"New student {newStudentFirstName} {newStudentLastName} has been added";
            var messafeBoxCaption = "New Student Added";
            MessageBox.Show(messageBoxMessage, messafeBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
