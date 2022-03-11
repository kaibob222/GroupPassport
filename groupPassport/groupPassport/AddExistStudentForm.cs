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
    public partial class AddExistStudentForm : Form
    {
        int groupId;
        public AddExistStudentForm(int _groupId)
        {
            InitializeComponent();
            groupId = _groupId;
        }

        private void AddExistStudentForm_Load(object sender, EventArgs e)
        {
            var C = new Context();
            studentsComboBox.DataSource = C.Students.Where(c => c.GroupId != groupId).Select(c => c.Id + " " + c.SurName + " " + c.FirstName + " " + c.MiddleName).ToList();
            studentsComboBox.SelectedItem = null;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (studentsComboBox.SelectedItem != null)
            {
                int studentId;
                studentId = Convert.ToInt32(studentsComboBox.SelectedItem.ToString().Split(' ')[0]);
                StudentLogic.AddExistStudent(studentId, groupId);
                this.Close();
            }
        }
    }
}
