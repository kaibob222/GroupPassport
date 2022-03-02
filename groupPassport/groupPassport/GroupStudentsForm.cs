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
            var group = C.Groups.Where(c => c.Id == id);
            var data = group
                .Select(c => c.Students
                    .Select(con => new { 
                        Id = con.Id,
                        FirstName = con.FirstName,
                        SurName = con.SurName,
                        MiddleName = con.MiddleName
                    })).FirstOrDefault();

            groupStudentsData.DataSource = data.ToList();
            groupNameLabel.Text = "Группа " + group.FirstOrDefault().GroupName;
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
                int studentId = Convert.ToInt32(groupStudentsData.CurrentRow.Cells[0].Value);

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
                int studentId = Convert.ToInt32(groupStudentsData.CurrentRow.Cells[0].Value);

                StudentLogic.DeleteStudent(studentId);
                GroupStudentsForm_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Нет студентов");
            }

        }
    }
}
