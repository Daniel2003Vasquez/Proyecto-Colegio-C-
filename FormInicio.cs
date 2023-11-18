using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTercerCorte
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e) //Botón para Registrar Estudiantes
        {
            FormRegistrarEstudiante formRegistrarStudent = new FormRegistrarEstudiante();
            panelVisor.Controls.Clear(); //Preguntar si está bien
            formRegistrarStudent.TopLevel = false;
            formRegistrarStudent.FormBorderStyle = FormBorderStyle.None; //Muestra los bordes de la ventana
            panelVisor.Controls.Add(formRegistrarStudent);
            formRegistrarStudent.Dock = DockStyle.Fill; //Acopla el contenedor
            formRegistrarStudent.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e) //Botón para Perfil del Admin
        {
            FormPerfilAdmin formPerfilAdmin = new FormPerfilAdmin();
            panelVisor.Controls.Clear(); //Para limpiar los controles del panel
            formPerfilAdmin.TopLevel = false;
            formPerfilAdmin.FormBorderStyle = FormBorderStyle.None; //Muestra los bordes de la ventana
            panelVisor.Controls.Add(formPerfilAdmin);
            formPerfilAdmin.Dock = DockStyle.Fill; //Acopla el contenedor
            formPerfilAdmin.Show();
        }

        private void btnRegistrarMateria_Click(object sender, EventArgs e) //Boton para Registrar Materias
        {
            FormRegistrarMateria formRegistrarMateria = new FormRegistrarMateria();
            panelVisor.Controls.Clear(); //Para limpiar los controles del panel
            formRegistrarMateria.TopLevel = false;
            formRegistrarMateria.FormBorderStyle = FormBorderStyle.None; //Muestra los bordes de la ventana
            panelVisor.Controls.Add(formRegistrarMateria);
            formRegistrarMateria.Dock = DockStyle.Fill; //Acopla el contenedor
            formRegistrarMateria.Show();
        }

        private void btnRegistrarNota_Click(object sender, EventArgs e) //Botón Registrar Notas
        {
            FormRegistrarNotas formRegistrarNotas = new FormRegistrarNotas();
            panelVisor.Controls.Clear(); //Para limpiar los controles del panel
            formRegistrarNotas.TopLevel = false;
            formRegistrarNotas.FormBorderStyle = FormBorderStyle.None; //Muestra los bordes de la ventana
            panelVisor.Controls.Add(formRegistrarNotas);
            formRegistrarNotas.Dock = DockStyle.Fill; //Acopla el contenedor
            formRegistrarNotas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVerNotasPorEstudiante formVerNotasPorEstudiante = new FormVerNotasPorEstudiante();
            panelVisor.Controls.Clear(); //Para limpiar los controles del panel
            formVerNotasPorEstudiante.TopLevel = false;
            formVerNotasPorEstudiante.FormBorderStyle = FormBorderStyle.None; //Muestra los bordes de la ventana
            panelVisor.Controls.Add(formVerNotasPorEstudiante);
            formVerNotasPorEstudiante.Dock = DockStyle.Fill; //Acopla el contenedor
            formVerNotasPorEstudiante.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
