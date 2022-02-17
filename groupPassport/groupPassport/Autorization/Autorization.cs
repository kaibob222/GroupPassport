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
        private Person _currentPerson;
        private string _login;
        private string _password;
        private int Id;

        public Autorization()
        {
            InitializeComponent();
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
            if (_logic.GetPeopleList(_context, _login, _password).Count != 0)
            {
                Id = _logic.GetPeopleList(_context, _login, _password)[0].Id;
                MainForm f = new MainForm(_context, Id);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                AutorizationError f = new AutorizationError();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
