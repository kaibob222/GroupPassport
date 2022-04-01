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
    public partial class Autorization : Form
    {
        private AutorizationLogic _logic; 
        private Context _context;
        public Person _currentPerson;
        private string _login;
        private string _password;
        private int Id;

        public Autorization()
        {
            InitializeComponent();
            _logic = new AutorizationLogic();
            _context = new Context();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            _login = Login.Text;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            _password = Password.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _currentPerson = _logic.GetPeopleList( _login, _password);
            if ( _currentPerson != null)
            {
                
                GroupForm f = new GroupForm(_currentPerson);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                AutorizationError f = new AutorizationError();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }
    }
}
