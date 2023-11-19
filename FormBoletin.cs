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
    public partial class FormBoletin : Form
    {
        private long Numero_Identificacion;
        public FormBoletin(long cedula)
        {
            InitializeComponent();
            Numero_Identificacion = cedula;
        }

        public StreamReader Reader { get; set; }
        public string ruta_Estudiante = "datosEstudiante.txt"; //Solo para tomar nombre, correo e identificación
        public string ruta_Notas = "NotasDatoStudent.txt"; //Para tomar las notas
        public string ruta_Materias = "datosMaterias.txt"; //Para tomar el nombre y el serial 
        private void FormBoletin_Load(object sender, EventArgs e)
        {
            MostrarNombresMateriasLabel();   
            MostrarDatosEstudiante();
            MostrarNotas();
        }
        public void MostrarNombresMateriasLabel()
        {
            try
            {
                Label[] nombreMaterias = {labelMateria1, labelMateria2, labelMateria3, labelMateria4, labelMateria5, labelMateria6};
                string[] lineas = File.ReadAllLines(ruta_Materias);
                for (int i = 0; i < lineas.Length && i < nombreMaterias.Length; i++)
                {
                    string[] partes = lineas[i].Split(',');

                    if (partes.Length == 2) //El total de dimensiones del array
                    {
                        string materia = partes[0].Trim();
                        nombreMaterias[i].Text = materia;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Debes registrar materias");
            }

        }//Nombre de las materias

        public void MostrarDatosEstudiante() //Nombre, documento, correo
        {
            try
            {
                Reader = new StreamReader(ruta_Estudiante);
                while (!Reader.EndOfStream)
                {
                    string[] temp = Reader.ReadLine().Split(',');
                    if (temp[1] == Numero_Identificacion.ToString())
                    {
                        labelNombreB.Text = temp[0];
                        labeIdentificacionB.Text = temp[1];
                        labelCorreoB.Text = temp[4];
                        break;
                    }
                }
                Reader.Close();
            }
            catch
            {
                MessageBox.Show("Debes registrar materias");
            }
        }

        public void MostrarNotas() //Mostrar Notas
        {
            try
            {
                Reader = new StreamReader(ruta_Notas);
                while (!Reader.EndOfStream)
                {
                    string[] temp = Reader.ReadLine().Split(',');
                    if (temp[0] == Numero_Identificacion.ToString())
                    {
                        long nota1 = long.Parse(temp[1]);
                        long nota2 = long.Parse(temp[2]);
                        long nota3 = long.Parse(temp[3]);
                        long nota4 = long.Parse(temp[4]);
                        long nota5 = long.Parse(temp[5]);
                        long nota6 = long.Parse(temp[6]);
                        long promedio = long.Parse(temp[7]);

                        if (nota1 >= 30) { labelNota1.ForeColor = Color.Green; } else { labelNota1.ForeColor = Color.Red; }
                        if (nota2 >= 30) { labelNota2.ForeColor = Color.Green; } else { labelNota2.ForeColor = Color.Red; }
                        if (nota3 >= 30) { labelNota3.ForeColor = Color.Green; } else { labelNota3.ForeColor = Color.Red; }
                        if (nota4 >= 30) { labelNota4.ForeColor = Color.Green; } else { labelNota4.ForeColor = Color.Red; }
                        if (nota5 >= 30) { labelNota5.ForeColor = Color.Green; } else { labelNota5.ForeColor = Color.Red; }
                        if (nota6 >= 30) { labelNota6.ForeColor = Color.Green; } else { labelNota6.ForeColor = Color.Red; }
                        if (promedio >= 30) { labelPromedio.ForeColor = Color.Green; } else { labelPromedio.ForeColor = Color.Red; }
                        
                        labelNota1.Text = temp[1];
                        labelNota2.Text = temp[2];
                        labelNota3.Text = temp[3];
                        labelNota4.Text = temp[4];
                        labelNota5.Text = temp[5];
                        labelNota6.Text = temp[6];
                        labelPromedio.Text = temp[7];
                        break;
                    }
                }
            }
            catch
            { 
                MessageBox.Show("Debes registrar materias");
            }
        }
    }
}
