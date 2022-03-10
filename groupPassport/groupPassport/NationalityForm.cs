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
    public partial class NationalityForm : Form
    {
        Context context = new Context();

        public NationalityForm()
        {
            InitializeComponent();
        }

        private void NationalityForm_Load(object sender, EventArgs e)
        {
            var query = from c in context.Nationalities
                        select new { Id = c.Id, PersonNationality = c.PersonNationality };
            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNationality add = new AddNationality();
            add.ShowDialog();
            NationalityForm_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                Classes.Auxilary.DeleteNationality(Id);
            }
            catch
            {
                MessageBox.Show("ERROR: Ошибка в удалении группы");
            }
            NationalityForm_Load(sender, e);
        }
    }
}
