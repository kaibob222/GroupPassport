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
    public partial class CitizenshipForm : Form
    {
        Context context = new Context();

        public CitizenshipForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CitizenshipForm_Activated(object sender, EventArgs e)
        {
            CitizenshipForm_Load_1(sender, e);
        }

        private void CitizenshipForm_Load_1(object sender, EventArgs e)
        {
            var query = from c in context.Citizenships
                        select new { Id = c.Id, PersonCitizenship = c.PersonCitizenship };
            dataGridView1.DataSource = query.ToList();
        }

        private void добавить_Click(object sender, EventArgs e)
        {
            AddCitizenship add = new AddCitizenship();
            add.ShowDialog();
            CitizenshipForm_Load_1(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                Classes.Auxilary.DeleteCitizenship(Id);
            }
            catch
            {
                MessageBox.Show("ERROR: Ошибка в удалении группы");
            }
            CitizenshipForm_Load_1(sender, e);
        }
    }
}
