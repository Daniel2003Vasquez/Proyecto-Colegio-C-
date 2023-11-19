using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Diagnostics.Eventing.Reader;

namespace ProyectoTercerCorte
{
    public partial class FormRegistrarNotas : Form
    {
        public FormRegistrarNotas()
        {
            InitializeComponent();
        }

        public StreamReader Reader { get; set; }

        public string ruta_Estudiante = "datosEstudiante.txt";
        public string ruta_Datos_Estudiantes_Notas = "NotasDatoStudent.txt";
        public long identificacion;

        private void FormRegistrarNotas_Load(object sender, EventArgs e)
        {
        }
        public bool ValidarEstudiantEntxt()
        {
            identificacion = long.Parse(txtIdentificacion.Text);
            if (File.Exists(ruta_Estudiante))
            {
                Reader = new StreamReader(ruta_Estudiante);
                while (!Reader.EndOfStream)
                {
                    string[] tempo = Reader.ReadLine().Split(',');
                    if (tempo[1] == identificacion.ToString())
                    {
                        Reader.Close();
                        return true;
                    }
                }
                Reader.Close();
            }
            MessageBox.Show("No se encuentra registrado");
            txtIdentificacion.Text = "";
            return false;
        }

        public bool ValidarEstudianteNota() //Para saber si ya tiene calificación
        {
            identificacion = long.Parse(txtIdentificacion.Text);
            if (File.Exists(ruta_Datos_Estudiantes_Notas))
            {
                Reader = new StreamReader(ruta_Datos_Estudiantes_Notas);
                while (!Reader.EndOfStream)
                {
                    string[] tempo = Reader.ReadLine().Split(',');
                    if (tempo[0] == identificacion.ToString())
                    {
                        Reader.Close();
                        MessageBox.Show("El estudiante ya tiene notas registradas");
                        txtIdentificacion.Text = "";
                        return false;
                    }
                }
                Reader.Close();
            }
            return true;
        }

        private void btnBuscarejo_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidarEstudiantEntxt()) 
                {
                    if(ValidarEstudianteNota())
                    {
                        FormComplementoRNotas formNotasLabel = null;
                        if(formNotasLabel == null || formNotasLabel.IsDisposed)
                        {
                            formNotasLabel = new FormComplementoRNotas(identificacion);
                            if(panel1Notas.Controls.Count > 0 ) 
                            {
                                panel1Notas.Controls.Clear();
                            }
                            formNotasLabel.TopLevel = false;
                            formNotasLabel.FormBorderStyle = FormBorderStyle.None;
                            panel1Notas.Controls.Add(formNotasLabel);
                            formNotasLabel.Dock = DockStyle.Fill;
                            formNotasLabel.Show();
                            txtIdentificacion.Text = "";
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingrese datos, por favor");
                txtIdentificacion.Text = "";
            }
        }

        //private void txtIdentificacion_Leave(object sender, EventArgs e)
        //{
        //    //TextBox textBoxId = (TextBox)sender;
        //    //try
        //    //{
        //    //    long.Parse(txtIdentificacion.Text);
        //    //    errorProvider1.SetError(textBoxId, "");
        //    //}
        //    //catch
        //    //{
        //    //    errorProvider1.SetError(textBoxId, "Ingrese números");
        //    //    textBoxId.Focus();
        //    //}
        //}
    }
}
