using Entidad;
using Negocio;
using System;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace Presentacion
{
    public partial class Login : Form
    {

        ELogin Ent = new ELogin(); // Entidad login

        public Login() // Iniciar login
        {
            InitializeComponent();
        }
        public void HabBotIng() // Habilitar botón ingresar
        {
            if ((textBox1.Text.Trim() != "") && (textBox2.Text.Trim() != ""))
            {
                loginb.Enabled = true;
            }
            else
            {
                loginb.Enabled = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e) // Cuando cambia textbox1
        {
            HabBotIng();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Cuando cambia textbox2
        {
            HabBotIng();
        }

        private void button2_Click(object sender, EventArgs e) // Al clickear salir
        {
            Application.Exit(); // Cerrar aplicación
        }

        private void button1_Click(object sender, EventArgs e) // Al clickear login
        {
            string Nombre = textBox1.Text;
            string Pass = textBox2.Text;
            NLogin Neg = new NLogin();
            int IdUsuario = Neg.Login(Nombre, Pass); // Llamar a función login
            Configuracion.Ent = new ELogin() { IdUsuario = IdUsuario };

            if (IdUsuario != 0) // Si el procedimiento devolvió un usuario
            {
                MessageBox.Show("Inicio de sesión exitoso"); // Se inicia la sesión
                // Inicio de sesión exitoso
                Menu MP = new Menu();
                MP.Show();
                this.Hide();
            }
            else // Si no
            {
                MessageBox.Show("Usuario o contraseña incorrectos"); // Mostrar error
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) // Si se presiona tecla en contraseña
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // Si se presiona tecla en usuario
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }
    }
}