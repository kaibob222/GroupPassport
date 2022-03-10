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
    public partial class DocumentForm : Form
    {
        Context context = new Context();

        public DocumentForm()
        {
            InitializeComponent();
        }

        private void DocumentForm_Load(object sender, EventArgs e)
        {
            var query = from c in context.Documents
                        select new { Id = c.Id, DocumentType = c.DocumentType, DocumentNumber = c.DocumentNumber };
            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDocument doc = new AddDocument();
            doc.Show();
            DocumentForm_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                Classes.Auxilary.DeleteDocument(Id);
            }
            catch
            {
                MessageBox.Show("ERROR: Ошибка в удалении группы");
            }
            DocumentForm_Load(sender, e);
        }
    }
}
