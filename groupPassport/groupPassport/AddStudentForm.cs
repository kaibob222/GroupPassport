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

        public AddStudentForm(int id, bool mode = false, int studId = -1)
        {
            InitializeComponent();
            groupId = id;
            isEditing = mode;
            studentId = studId;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            if (isEditing)
            {
                var C = new Context();
                var student = C.People.Where(c => c.Id == studentId).FirstOrDefault();
                if (student != null)
                {
                    fNameTextBox.Text = student.FirstName;
                    sNameTextBox.Text = student.SurName;
                    mNameTextBox.Text = student.MiddleName;
                }
                dropButton.Visible = true;
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
    }
}
