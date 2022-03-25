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
    public partial class DocumentForm : Form
    {
        Context context = new Context();
        public Student Student { get; set; }

        public DocumentForm()
        {
            InitializeComponent();
        }

        private void DocumentForm_Load(object sender, EventArgs e)
        {
            var query = Student.Documents;//from c in context.Documents
                        //select new { Id = c.Id, DocumentType = c.DocumentType, DocumentNumber = c.DocumentNumber };
            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDocument doc = new AddDocument();
            doc.student = Student;
            doc.ShowDialog();
            Student = (new Context()).Students.Where(s => s.Id == Student.Id).FirstOrDefault();
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
