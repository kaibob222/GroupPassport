using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using groupPassport.Classes;

namespace groupPassport
{
    public partial class AddStudentForm : Form
    {
        int groupId;
        bool isEditing = false;
        int studentId;
        Student student;

        public AddStudentForm(int id, bool mode = false, int studId = -1)
        {
            InitializeComponent();
            groupId = id;
            isEditing = mode;
            studentId = studId;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            var C = new Context();

            if (isEditing)
            {
                student = C.Students.Where(c => c.Id == studentId).FirstOrDefault();
                if (student != null)
                {
                    fNameTextBox.Text = student.FirstName;
                    sNameTextBox.Text = student.SurName;
                    mNameTextBox.Text = student.MiddleName;
                    
                }
                dropButton.Visible = true;
            }
            button1.Visible = isEditing;
            int n = C.Nationalities.Count();
            int m = C.Citizenships.Count();
            //textBox1.Text = Convert.ToString(n);
            //foreach (DataRow row in C.Nationalities)
            //NationalityBox.Items.AddRange(C.Nationalities.SqlQuery(@"SELECT PersonNationality from Nationalities"));
            for (int i=1; i<=n; i++)
            {
                //NationalityBox.Items.Add(C.Nationalities.SelectMany);
            }
            for (int i = 1; i <= m; i++)
            {
                //CitizenshipBox.Items.Add(C.Citizenships.Select(c => c.Id == i).FirstOrDefault().ToString());
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            string fName = fNameTextBox.Text;
            string sName = sNameTextBox.Text;
            string mName = mNameTextBox.Text;

            if (fName != "" && sName != "" && mName != "") {
                if (!isEditing)
                {
                    StudentLogic.AddStudent(fName,
                        sName,
                        mName,
                        groupId);
                }
                else
                {
                    StudentLogic.EditStudent(studentId, fName, sName, mName);
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("Проверьте введенные данные");
            }
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            AddStudentForm_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocumentForm docf = new DocumentForm();
            docf.Student = student;
            docf.Show();
            AddStudentForm_Load(sender, e);
        }
    }
}
