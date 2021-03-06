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
    public partial class AddNationality : Form
    {
        public int NationalityId { get; set; }
        public AddNationality()
        {
            InitializeComponent();
            NationalityId = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NationalityId >= 0)
            {
                Classes.Auxilary.EditCitizenship(NationalityId, textBox1.Text);
            }
            else
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        Classes.Auxilary.AddNationality(textBox1.Text);
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
}
