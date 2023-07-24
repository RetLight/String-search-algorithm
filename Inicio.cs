using System;
using Functions;

namespace C____BUSQUEDA
{
    public partial class Inicio : Form
    {
        public void IniciarInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string user = Functions.Functions.Login(codigo.Text, password.Text); 
            if (user != "")
            {
                this.Hide();
                Home p = new Home();
                p.IniciarHome(user);
                p.ShowDialog();
                codigo.Text = string.Empty;
                password.Text = string.Empty;
                this.Show();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña han sido incorrecto. \nIngreselos de nuevo");
                codigo.Text = string.Empty;
                password.Text = string.Empty;
            }
        }
    }
}