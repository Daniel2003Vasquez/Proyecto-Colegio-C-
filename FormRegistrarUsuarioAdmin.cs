using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTercerCorte
{
    public partial class FormRegistrarUsuarioAdmin : Form
    {
        public StreamWriter writer { get; set; }
        public FormRegistrarUsuarioAdmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
            txtRepetirContrasena.UseSystemPasswordChar = true;
        }

        public void Limpiar()
        {
            txtName.Text = "";
            txtTelefono.Text = "";
            txtCedula.Text = "";
            txtContrasena.Text = "";
            txtRepetirContrasena.Text = "";
            txtCorreo.Text = "";
            comboNacionalidad.Text = "";
            txtDireccion.Text = "";
            DateFechaNacimiento.Text = "";

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtCedula.Text;
        }

        private void btnRegistrarAdmin_Click(object sender, EventArgs e)
        {
            string ruta_Admin = "datosAdmin.txt";
            string ruta_Login = "datosLogin.txt";

            string datosAdmin = $"{txtName.Text},{txtTelefono.Text},{txtCedula.Text},{txtUsername.Text},{txtContrasena.Text},{txtCorreo.Text},{comboNacionalidad.Text},{txtDireccion.Text},{DateFechaNacimiento.Text}";
            string datosLogin = $"{txtUsername.Text},{txtContrasena.Text}";
            if(txtContrasena.Text == txtRepetirContrasena.Text ) 
            {
                try
                {
                    if(!File.Exists(ruta_Admin)) 
                    {
                        //Guardamos los datos del usuario
                        this.writer = File.AppendText(ruta_Admin);
                        this.writer.WriteLine(datosAdmin);
                        this.writer.Close();
                        //Guardamos los datos del login
                        this.writer = File.AppendText(ruta_Login);
                        this.writer.WriteLine(datosLogin);
                        this.writer.Close();
                        this.Close(); //Cerrar formulario
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un admin Registrado");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en btnLogin\n Revisar");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
                txtContrasena.Text = "";
                txtRepetirContrasena.Text = "";
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            TextBox textBoxPhone = (TextBox)sender;
            try
            {
                if (textBoxPhone.Name.Equals("txtTelefono"))
                {
                    long.Parse(txtTelefono.Text);
                    errorProvider1.SetError(textBoxPhone, "");
                }
            }
            catch
            {
                errorProvider1.SetError(textBoxPhone, "Ingrese números, no letras");
                textBoxPhone.Focus();
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            TextBox textBoxId = (TextBox)sender;
            try
            {
                if (textBoxId.Name.Equals("txtCedula"))
                {
                    long.Parse(txtCedula.Text);
                    errorProvider1.SetError(textBoxId, "");
                }
            }
            catch
            {
                errorProvider1.SetError(textBoxId, "Ingrese números, no letras");
                textBoxId.Focus();
            }
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
