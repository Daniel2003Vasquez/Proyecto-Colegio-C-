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

namespace ProyectoTercerCorte
{
    public partial class FormRegistrarNotas : Form
    {
        public FormRegistrarNotas()
        {
            InitializeComponent();
        }

        public long id;
        public string ruta_Estudiante = "datosEstudiante.txt";
        public string ruta_Datos_Estudiantes_Notas = "NotasDatoStudent.txt";

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
                if (ValidarEstudiante() == true)
                {
                    FormComplementoRNotas formNotasLabel = new FormComplementoRNotas(id);
                    panel1Notas.Controls.Clear();
                    formNotasLabel.TopLevel = false;
                    formNotasLabel.FormBorderStyle = FormBorderStyle.None;
                    panel1Notas.Controls.Add(formNotasLabel);
                    formNotasLabel.Dock = DockStyle.Fill;
                    formNotasLabel.Show();
                    txtIdNe.Text = "";
                }
            }catch
            { 
                MessageBox.Show("Ingrese una identificación para buscar "); 
            }
        }

        private void FormRegistrarNotas_Load(object sender, EventArgs e)
        {

        }

        public bool ValidarEstudiante()
        {
            id = long.Parse(txtIdNe.Text);
            string[] linea = File.ReadAllLines(ruta_Estudiante);
            string[] aprobacion = File.ReadAllLines(ruta_Datos_Estudiantes_Notas);
            foreach (string student in linea) //Saber si está registrado
            {
                if (student.Contains(id.ToString()))
                {
                    return true;
                }
            }
            MessageBox.Show("El id no se encuentra registrado");
            txtIdNe.Text = "";
            return false;
        }

    }
}
