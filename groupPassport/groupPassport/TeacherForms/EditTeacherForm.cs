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
namespace groupPassport.TeacherForms
{
    public partial class EditTeacherForm : Form
    {
        Context C;
        int id=2;
        Classes.Teacher teacher;
        public EditTeacherForm(int _id)
        {
            id = _id;
            InitializeComponent();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Position p = (Position)Enum.Parse(typeof(Position), (string)comboBox1.SelectedValue);
            EditTeacherLogic.apply(C, id, textBox1.Text, textBox2.Text, textBox3.Text,textBox4.Text,p);
            this.Close();
        }

        private void EditTeacherForm_Load(object sender, EventArgs e)
        {
            C = new Context();
            teacher = C.Teachers.Where(c => c.Id == id).FirstOrDefault();

            if (teacher == null)
            {
                MessageBox.Show(" Учитель не найден");
                this.Close();
            }
           
            comboBox1.DataSource = new BindingSource(Classes.DescriptionAttributes<Classes.Position>.RetrieveAttributes(), null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";

            
            comboBox1.SelectedItem = comboBox1.Items.Cast<KeyValuePair<string, string>>()
                .Where(x => x.Value==teacher.Position.ToString()).FirstOrDefault();

            listBox1.DataSource = C.Groups.ToList();
            listBox1.DisplayMember = "GroupName";
            listBox1.ValueMember = "Id";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            
            //foreach (var group in teacher.Groups)
            //{
            //    if(listBox1.Items.)
            //}

            textBox1.Text = teacher.SurName;
            textBox2.Text = teacher.FirstName;
            textBox3.Text = teacher.MiddleName;
            textBox4.Text = teacher.Password;

           
        }
    }
}
