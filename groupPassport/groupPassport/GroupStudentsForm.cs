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
    public partial class GroupStudentsForm : Form
    {
        int id;
        public GroupStudentsForm(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void GroupStudentsForm_Load(object sender, EventArgs e)
        {
            var C = new Context();
            var group = C.Groups.Where(c => c.Id == id).FirstOrDefault();
            if (group == null)
            {
                MessageBox.Show("Группа не найдена");
                this.Close();
            }

            groupStudentsData.DataSource = group.Students;
            groupNameLabel.Text = "Группа " + group.GroupName;
            groupStudentsData.Columns[0].Visible = false;
            groupStudentsData.Columns[1].Visible = false;
            groupStudentsData.Columns[2].Visible = false;

        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            var f = new AddStudentForm(id);
            f.ShowDialog();
            GroupStudentsForm_Load(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (groupStudentsData.RowCount > 0) { 
                int studentId = Convert.ToInt32(groupStudentsData.CurrentRow.Cells[2].Value);

                var f = new AddStudentForm(id, true, studentId);
                f.ShowDialog();
                GroupStudentsForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Нет студентов");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (groupStudentsData.RowCount > 0)
            {
                int studentId = Convert.ToInt32(groupStudentsData.CurrentRow.Cells[2].Value);

                StudentLogic.DeleteStudent(studentId, id);
                GroupStudentsForm_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Нет студентов");
            }

        }

        private void AddExistStudentButton_Click(object sender, EventArgs e)
        {
            var f = new AddExistStudentForm(id);
            f.ShowDialog();
            GroupStudentsForm_Load(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bookTextBox_TextChanged(object sender, EventArgs e)
        {
            int num = -1;
            try
            {
                num = Convert.ToInt32(bookTextBox.Text);    
            }
            catch
            {
                MessageBox.Show("Неправильный формат");
            }

            if (num > -1)
            {
                var students = StudentLogic.FilterBookStudent(num, id);

                groupStudentsData.DataSource = students;
                groupStudentsData.Columns[0].Visible = false;
                groupStudentsData.Columns[1].Visible = false;
                groupStudentsData.Columns[2].Visible = false;
            }        
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            string s = nameTextBox.Text;
            if (s != "") {
                var students = StudentLogic.FilterNameStudent(s, id);

                groupStudentsData.DataSource = students;
                groupStudentsData.Columns[0].Visible = false;
                groupStudentsData.Columns[1].Visible = false;
                groupStudentsData.Columns[2].Visible = false;
            }
            else
            {
                GroupStudentsForm_Load(sender, e);
            }
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            birthDateTimePicker.Value = DateTime.Today;

            GroupStudentsForm_Load(sender, e);
        }

        private void birthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = birthDateTimePicker.Value;
            if (date != DateTime.Today)
            {
                StudentLogic.FilterDateStudent(date, id);
            }
        }
    }
}
