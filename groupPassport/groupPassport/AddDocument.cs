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
    public partial class AddDocument : Form
    {
        public AddDocument()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                try
                {
                    Classes.Auxilary.AddDocument(textBox2.Text, comboBox1.SelectedValue.ToString(), Convert.ToInt32(textBox1.Text));
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка в добавлении группы!");
                }
            }
            else
            {
                MessageBox.Show("Введите все данные!");
            }
            AddDocument_Load(sender, e);
        }

        private void AddDocument_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(DocumentType));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
