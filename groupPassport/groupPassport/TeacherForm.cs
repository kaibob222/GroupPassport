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
    public partial class TeacherForm : Form
    {
        Context context = new Context();

        public TeacherForm()
        {
            
            InitializeComponent();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
