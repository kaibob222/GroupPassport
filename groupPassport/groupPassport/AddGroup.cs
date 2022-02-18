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
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    Classes.GroupLogic.AddGroup(textBox1.Text, Convert.ToInt32(textBox2.Text));
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
    }
}
