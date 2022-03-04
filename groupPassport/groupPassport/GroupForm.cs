﻿using System;
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

        private void GroupForm_Load(object sender, EventArgs e)
        {
            var query = from c in context.Groups
                        select new { Id = c.Id, GroupName = c.GroupName, Year = c.Year };
            dataGridView1.DataSource = query.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var f = new EditGroupForm(id);
            f.ShowDialog();
            dataGridView1.DataSource = context.Groups.ToList();
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
                    var searchQuery = Classes.GroupLogic.SearchGroup(textBox1.Text, comboBox1.SelectedIndex);
                    button4.Visible = true;
                    dataGridView1.DataSource = searchQuery.ToList();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            GroupForm_Load(sender, e);
            button4.Visible = false;
        }
    }
}
