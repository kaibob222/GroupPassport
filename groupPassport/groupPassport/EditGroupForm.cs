using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using groupPassport.Classes;

namespace groupPassport
{
    public partial class EditGroupForm : Form
    {
        Context C;
        public int id = 1;
        int startYear = 2015;
        int countYear = 100;
        Group group;
        public EditGroupForm(int _id)
        {
            InitializeComponent();
            id = _id;
            for (int i = 0; i < countYear; i++)
            {
                year.Items.Add(startYear + i);
            }
        }

        private void drop_Click(object sender, EventArgs e)
        {
            var g = GroupLogic.DropEditData(C, id);

            groupName.Text = g.GroupName;
            year.SelectedIndex = (g.Year - startYear);
        }

        private void apply_Click(object sender, EventArgs e)
        {
            GroupLogic.ApplyEditChanges(C, id, groupName.Text, Convert.ToInt32(year.SelectedItem));

            this.Close();
        }

        private void EditGroupForm_Load(object sender, EventArgs e)
        {
            C = new Context();
            group = C.Groups.Where(c => c.Id == id).FirstOrDefault();

            groupName.Text = group.GroupName;
            year.SelectedIndex = (group.Year - startYear);
        }
    }
}
