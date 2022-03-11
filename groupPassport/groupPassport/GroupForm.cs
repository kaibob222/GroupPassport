using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupPassport
{
    public partial class GroupForm : Form
    {
        Context context = new Context();

        public GroupForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            var query = from c in context.Groups
                        select new { Id = c.Id, GroupName = c.GroupName, Year = c.Year };
            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0) { 
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var f = new EditGroupForm(id);
                f.ShowDialog();
                dataGridView1.DataSource = context.Groups.ToList();

            }
            else
            {
                MessageBox.Show("Нет групп");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGroup add = new AddGroup();
            add.Show();
        }

        private void GroupForm_Activated(object sender, EventArgs e)
        {
            GroupForm_Load(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int groupId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                Classes.GroupLogic.DeleteGroup(groupId);
            }
            catch
            {
                MessageBox.Show("ERROR: Ошибка в удалении группы");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    try
                    {
                        var searchQuery = Classes.GroupLogic.SearchGroup(textBox1.Text, comboBox1.SelectedIndex);
                        button4.Visible = true;
                        dataGridView1.DataSource = searchQuery.ToList();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка в поиске");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Поиск по...";
            GroupForm_Load(sender, e);
            button4.Visible = false;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int groupId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            var f = new GroupStudentsForm(groupId);
            f.ShowDialog();
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            int groupId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            var f = new GroupStudentsForm(groupId);
            f.ShowDialog();
        }

        private void click(object sender, EventArgs e)
        {
            int groupId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            try
            {
                var f = new GroupStudentsForm(groupId);
                f.ShowDialog();
            }
            catch
            {

            }
        }

        private void гражданствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CitizenshipForm form = new CitizenshipForm();
            form.Show();
        }

        private void национальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NationalityForm form2 = new NationalityForm();
            form2.Show();
        }
    }
}
