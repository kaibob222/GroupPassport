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
    public partial class TeacherForm : Form
    {
        Context context = new Context();
        private Teacher currentuser;

        public TeacherForm(Teacher _user)
        {
            currentuser = _user;
            InitializeComponent();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentuser.Position == Position.admin)
            {
                TeacherForms.AddTeacher add = new TeacherForms.AddTeacher();
                add.ShowDialog();
                Context c = new Context();
                dataGridView1.DataSource = c.Teachers.ToList();
            }
            else MessageBox.Show("Вы не можете добавлять сотрудников!");
        }
        private void TeacherForm_Activated(object sender, EventArgs e)
        {
            TeacherForm_Load(sender, e);
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            dataGridView1.DataSource = c.Teachers.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentuser.Position == Position.admin || currentuser.Groups != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                TeacherForms.EditTeacherForm editTeacher = new TeacherForms.EditTeacherForm(id);
                editTeacher.ShowDialog();
                dataGridView1.DataSource = context.Teachers.ToList();
            }
            else MessageBox.Show("Вы не можете редактировть данные сотрудников!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentuser.Position == Position.admin)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                try
                {
                    DeleteTeacherLogic.DeleteTeacher(id);
                }
                catch
                {
                    MessageBox.Show("ERROR: Ошибка в удалении пользователя");
                }
                dataGridView1.DataSource = context.Teachers.ToList();
            }
            else MessageBox.Show("Вы не можете удалять сотрудников!");
        }
    }
}
