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
    public partial class GroupStudentsForm : Form
    {
        public GroupStudentsForm()
        {
            InitializeComponent();
        }

        private void GroupStudentsForm_Load(object sender, EventArgs e)
        {
            var C = new Context();
            groupStudentsData.DataSource = C.Groups.Where(c => c.Id == 1).Select(c => c.Students);

        }
    }
}
