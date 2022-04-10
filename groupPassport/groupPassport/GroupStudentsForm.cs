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
        List<Student> studentsData = new List<Student>();
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

            studentsData = group.Students;
            groupNameLabel.Text = "Группа " + group.GroupName;
            dataSourceInit(studentsData);
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            var f = new AddStudentForm(id);
            f.ShowDialog();
            dropButton_Click(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (groupStudentsData.RowCount > 0) { 
                int studentId = Convert.ToInt32(groupStudentsData.CurrentRow.Cells[2].Value);

                var f = new AddStudentForm(id, true, studentId);
                f.ShowDialog();
                dropButton_Click(sender, e);
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

                StudentLogic.DeleteStudent(studentId);
                dropButton_Click(sender, e);
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
            dropButton_Click(sender, e);
        }

        private void bookTextBox_TextChanged(object sender, EventArgs e)
        {
            int num = -1;

            if (bookTextBox.Text != "") {
                try
                {
                    string str = bookTextBox.Text;
                    var arr = str.Split(' ').ToList();
                    arr.Remove("");
                    if (arr.Count == 1)
                    {
                        num = Convert.ToInt32(arr[0]);
                        studentsData = StudentLogic.FilterBookStudent(studentsData, str);
                        dataSourceInit(studentsData);
                    }
                    else throw new Exception();
                }
                catch
                {
                    MessageBox.Show("Неправильный формат номера зачетной книжки");
                }
            }
            else if (bookTextBox.Focused)
            {
                studentsData = new Context().Students.Where(c => c.GroupId == id).ToList();
                nameTextBox_TextChanged(sender, e);
                birthDateTimePicker_ValueChanged(sender, e);
            
                dataSourceInit(studentsData);
            }       
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            string s = nameTextBox.Text;
            if (s != "") {
                studentsData = StudentLogic.FilterNameStudent(studentsData, s);

                dataSourceInit(studentsData);
            }
            else if (nameTextBox.Focused)
            {
                studentsData = new Context().Students.Where(c => c.GroupId == id).ToList();
                bookTextBox_TextChanged(sender, e);
                birthDateTimePicker_ValueChanged(sender, e);

                dataSourceInit(studentsData);
            }
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            birthDateTimePicker.Value = DateTime.Today;
            birthDateTimePicker.Checked = false;
            bookTextBox.Text = "";

            GroupStudentsForm_Load(sender, e);
        }

        private void birthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = birthDateTimePicker.Value.Date;

            if (birthDateTimePicker.Checked) {
                studentsData = new Context().Students.Where(c => c.GroupId == id).ToList();
                bookTextBox_TextChanged(sender, e);
                nameTextBox_TextChanged(sender, e);

                dataSourceInit(studentsData);
                studentsData = StudentLogic.FilterDateStudent(studentsData, date);
                dataSourceInit(studentsData);

            }
            else if (birthDateTimePicker.Focused)
            {
                studentsData = new Context().Students.Where(c => c.GroupId == id).ToList();
                bookTextBox_TextChanged(sender, e);
                nameTextBox_TextChanged(sender, e);

                dataSourceInit(studentsData);
            }
        }

        void dataSourceInit(List<Student> students)
        {
            groupStudentsData.DataSource = students;
            groupStudentsData.Columns[0].Visible = false;
            groupStudentsData.Columns[1].Visible = false;
            groupStudentsData.Columns[8].Visible = false;
            groupStudentsData.Columns[9].Visible = false;
        }
    }
}
