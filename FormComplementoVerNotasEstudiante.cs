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

namespace ProyectoTercerCorte
{
    public partial class FormComplementoVerNotasEstudiante : Form
    {
        private long Num_cedula;
        public FormComplementoVerNotasEstudiante(long cedula)
        {
            InitializeComponent();
            Num_cedula = cedula;
        }
        
        public string ruta = "datosMaterias.txt";
        public string ruta_Estudiantes_Con_Notas = "NotasDatoStudent.txt";
        public string ruta_Datos_Estudiante = "datosEstudiante.txt";
        
        private void FormComplementoVerNotasEstudiante_Load(object sender, EventArgs e)
        {
            MostrarDatosMateriaEnLabel();
            MostrarNombreEnLabel();
            MostrarNotasEnlabel();
        }

        public void MostrarDatosMateriaEnLabel()
        {
            try
            {
                string[] lineas = File.ReadAllLines(ruta);

                Label[] nombreMaterias = {LbNota1, LbNota2, LbNota3, LbNota4, LbNota5, LbNota6 };

                for (int i = 0; i < lineas.Length && i < nombreMaterias.Length; i++)
                {
                    string[] partes = lineas[i].Split(',');

                    if (partes.Length == 2) //El total de dimensiones del array
                    {
                        string nota = partes[0].Trim();
                        nombreMaterias[i].Text = nota;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Debes registrar materias");
            }
        }
        
        public void MostrarNombreEnLabel()
        {
            try
            {
                string[] lineas = File.ReadAllLines(ruta_Datos_Estudiante);
                foreach (string estudiante in lineas)
                {
                    if (estudiante.Contains(Num_cedula.ToString()))
                    {
                        string[] datosEstudiante = estudiante.Split(',');
                        if (datosEstudiante.Length > 0)
                        {
                            LbNombrEstudiante.Text = datosEstudiante[0];
                        }
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Debes registrar materias");
            }
        }

        public void MostrarNotasEnlabel()
        {
            try
            {
                string[] lineas = File.ReadAllLines(ruta_Estudiantes_Con_Notas);
                foreach (string leer in lineas)
                {
                    if (leer.Contains(Num_cedula.ToString()))
                    {
                        string[] datosEstudiante = leer.Split(',');
                        if (datosEstudiante.Length > 0)
                        {
                            long nota1 = long.Parse(datosEstudiante[1]);
                            long nota2 = long.Parse(datosEstudiante[2]);
                            long nota3 = long.Parse(datosEstudiante[3]);
                            long nota4 = long.Parse(datosEstudiante[4]);
                            long nota5 = long.Parse(datosEstudiante[5]);
                            long nota6 = long.Parse(datosEstudiante[6]);
                            long promedio = long.Parse(datosEstudiante[7]);

                            if (nota1 >= 30) { Aprobado1.Text = "Aprobado"; Aprobado1.ForeColor = Color.Green; } else { Aprobado1.Text = "Desaprobado"; Aprobado1.ForeColor = Color.Red; }
                            if (nota2 >= 30) { Aprobado2.Text = "Aprobado"; Aprobado2.ForeColor = Color.Green; } else { Aprobado2.Text = "Desaprobado"; Aprobado2.ForeColor = Color.Red; }
                            if (nota3 >= 30) { Aprobado3.Text = "Aprobado"; Aprobado3.ForeColor = Color.Green; } else { Aprobado3.Text = "Desaprobado"; Aprobado3.ForeColor = Color.Red; }
                            if (nota4 >= 30) { Aprobado4.Text = "Aprobado"; Aprobado4.ForeColor = Color.Green; } else { Aprobado4.Text = "Desaprobado"; Aprobado4.ForeColor = Color.Red; }
                            if (nota5 >= 30) { Aprobado5.Text = "Aprobado"; Aprobado5.ForeColor = Color.Green; } else { Aprobado5.Text = "Desaprobado"; Aprobado5.ForeColor = Color.Red; }
                            if (nota6 >= 30) { Aprobado6.Text = "Aprobado"; Aprobado6.ForeColor = Color.Green; } else { Aprobado6.Text = "Desaprobado"; Aprobado6.ForeColor = Color.Red; }

                            LbMostrarNota1.Text = nota1.ToString();
                            LbMostrarNota2.Text = nota2.ToString();
                            LbMostrarNota3.Text = nota3.ToString();
                            LbMostrarNota4.Text = nota4.ToString();
                            LbMostrarNota5.Text = nota5.ToString();
                            LbMostrarNota6.Text = nota6.ToString();
                            LbMostrarDefinitiva.Text = promedio.ToString();
                            break;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingresa un dato para continuar");
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
