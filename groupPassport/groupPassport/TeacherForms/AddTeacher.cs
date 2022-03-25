using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using groupPassport.Classes
    ;
namespace groupPassport.TeacherForms
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new BindingSource(Classes.DescriptionAttributes<Position>.RetrieveAttributes(), null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                try
                {
                    Position p = (Position)Enum.Parse(typeof(Position), (string)comboBox1.SelectedValue);
                    AddTeacherLogic.AddTeacher(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,p);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка в добавлении учителя!");
                }
            }
            else
            {
                MessageBox.Show("Введите все данные!");
            }
        }
    }
}
