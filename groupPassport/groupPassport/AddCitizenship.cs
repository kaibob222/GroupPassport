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
    public partial class AddCitizenship : Form
    {
        public AddCitizenship()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                try
                {
                    Classes.Auxilary.AddCitizenship(textBox1.Text);
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
        }

        private void AddCitizenship_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCitizenship_Activated(object sender, EventArgs e)
        {
            AddCitizenship_Load(sender, e);
        }
    }
}
