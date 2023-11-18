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
    public partial class FormPerfilAdmin : Form
    {
        public FormPerfilAdmin()
        {
            InitializeComponent();
        }

        public StreamReader Reader { get; set; }

        private void FormPerfilAdmin_Load(object sender, EventArgs e)
        {
            string ruta = "datosAdmin.txt";
            Reader = new StreamReader(ruta);
            string leer;
            while((leer = Reader.ReadLine()) != null) 
            {
                string[] datos_Posicion = leer.Split(',');
                string nombreCompleto = datos_Posicion[0];
                string telefono = datos_Posicion[1];
                string cedula = datos_Posicion[2];
                string username = datos_Posicion[3];
                string correo = datos_Posicion[5];
                string nacionalidad = datos_Posicion[6];
                string ciudad = datos_Posicion[7];
                string fecha = datos_Posicion[8];

                txtNameA.Text = nombreCompleto;
                txtTelefonoA.Text = telefono;
                txtCedulaA.Text = cedula;
                txtUsernameA.Text = username;
                txtCorreoA.Text = correo;
                txtNacionalidadA.Text = nacionalidad;
                txtCiudadA.Text = ciudad;
                txtFechaNacimientoA.Text = fecha;
            }
            Reader.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
