using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeFrete
{
    public partial class Login : Form
    {

        public string login {  get; set; }
        public int Password { get; set; }
        public Login()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            login = textLogin.Text;
            if (int.TryParse(textPassword.Text, out int password))
            {
                Password = password;
                if (login == "admin" && password == 123456)
                {
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Digite um login validdo!");
                }
            }
            else
            {
                MessageBox.Show("Digite uma senha numerica valida");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
      

        }
    }
}
