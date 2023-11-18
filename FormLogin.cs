using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTercerCorte
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public StreamReader Reader { get; set; }
        private void FormLogin_Load(object sender, EventArgs e) 
        {
            txtContrasena.UseSystemPasswordChar = true;
        }

        public void LimpiarLogin()
        {
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string ruta_Login = "datosLogin.txt";
            try
            {
                if (File.Exists(ruta_Login))
                {
                    this.Reader = new StreamReader(ruta_Login);
                    while (!Reader.EndOfStream)
                    {
                        string leer = Reader.ReadLine();
                        string[] temp = leer.Split(',');
                        if (txtUsuario.Text == temp[0] && txtContrasena.Text == temp[1])
                        {
                            //Inicializamos el FormInicio
                            
                            FormInicio formInicio = new FormInicio();
                            formInicio.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña o usuario incorrectos");
                            LimpiarLogin();
                        }
                    }
                    Reader.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error \nRevisar FormLogin << btnIngresar >>");
            }
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarLogin();
        }

        private void checkVerContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !checkVerContrasena.Checked;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            TextBox textBoxUser = (TextBox)sender;
            try
            {
                if (textBoxUser.Name.Equals("txtUsuario"))
                {
                    long.Parse(textBoxUser.Text);
                    errorProvider1.SetError(textBoxUser, "");
                }
            }
            catch (Exception)
            {
                errorProvider1.SetError(textBoxUser, "Ingrese números, no letras");
                textBoxUser.Focus();
            }
        }
    }
}
