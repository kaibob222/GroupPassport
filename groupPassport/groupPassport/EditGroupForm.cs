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
    public partial class EditGroupForm : Form
    {
        public Context C { get; set; }
        public int id = 1;
        int startYear = 2022;
        int countYear = 100;
        public EditGroupForm()
        {
            InitializeComponent();
            for (int i = 0; i < countYear; i++)
            {
                year.Items.Add(startYear + i);
            }
        }

        private void drop_Click(object sender, EventArgs e)
        {
            //drop(C, id);

            var group = C.Groups.Where(c => c.Id == id).FirstOrDefault();
            if (group != null)
            {
                //return group;
            }

            groupName.Text = group.GroupName;
            //groupFullName.Text = group.GroupFullName;
            year.SelectedIndex = (group.Year - startYear);
        }

        private void apply_Click(object sender, EventArgs e)
        {
            //apply(C, id, groupName.text, groupFullName.text, year);

            var group = C.Groups.Where(c => c.Id == id).FirstOrDefault();
            if (group != null)
            {
                group.GroupName = groupName.Text;
                group.Year = Convert.ToInt32(year.SelectedItem);
                C.SaveChanges();
            }
            this.Close();
        }
    }
}
