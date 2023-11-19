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
    public partial class FormRegistrarMateria : Form
    {
        public FormRegistrarMateria()
        {
            InitializeComponent();
        }

        public StreamWriter WriterM { get; set; }
        public StreamReader Reader { get; set; }
        public string ruta_Materias = "datosMaterias.txt";

        public void LimpiarM()
        {
            comboNombreM.Text = "";
        }

        private void btnRegistrarM_Click(object sender, EventArgs e)
        {
            RegistrarMateria();
            LimpiarM();
        }

        private void btnCancelarM_Click(object sender, EventArgs e)
        {
            LimpiarM();
        }

        private void FormRegistrarMateria_Load(object sender, EventArgs e)
        {
            //ActualizarDataGridView();
        }

        public void RegistrarMateria()
        {
            try
            {
                string nombreMateria = comboNombreM.Text;
                Random random = new Random();
                var aleatorio = random.Next(1000, 1500);
                if(File.Exists(ruta_Materias)) 
                {
                    int contador = 0;
                    Reader = new StreamReader(ruta_Materias);
                    while (!Reader.EndOfStream)
                    {
                        contador++;
                        string[] tempo = Reader.ReadLine().Split(',');
                        if (tempo[0] == nombreMateria || tempo[1] == aleatorio.ToString())
                        {
                            MessageBox.Show("La materia ya se encuentra registrada");
                            Reader.Close();
                            comboNombreM.Text = "";
                            return;
                        }
                    }
                    Reader.Close();
                    if (contador >= 6)
                    {
                        MessageBox.Show("Solo se pueden registrar 6 materias\nSon humanos, no robots. Entiende");
                        return;
                    }
                    labelChismoso.Text = $"{comboNombreM.Text}\nSerial: {aleatorio}";
                    string datoMateria = $"{comboNombreM.Text},{aleatorio}";
                    WriterM = File.AppendText(ruta_Materias);
                    WriterM.WriteLine(datoMateria);
                    WriterM.Close();
                    LimpiarM();
                    ActualizarDataGridView();
                }
                else
                {
                    labelChismoso.Text = $"{comboNombreM.Text}\nSerial: {aleatorio}";
                    string datoMateria = $"{comboNombreM.Text},{aleatorio}";
                    WriterM = File.AppendText(ruta_Materias);
                    WriterM.WriteLine(datoMateria);
                    WriterM.Close();
                    LimpiarM();
                    ActualizarDataGridView();

                }
            }
            catch
            {
                Console.WriteLine("Se toteó esta cosa");
            }
        }

        public void ActualizarDataGridView()
        {
            try
            {
                dataGridView1.Rows.Clear();
                if (File.Exists(ruta_Materias))
                {
                    Reader = new StreamReader(ruta_Materias);
                    while (!Reader.EndOfStream)
                    {
                        string[] temp = Reader.ReadLine().Split(',');
                        dataGridView1.Rows.Add(temp);
                    }
                    Reader.Close();
                }
                else
                {
                    MessageBox.Show("El archivo no existe");
                }
            }
            catch
            {
                MessageBox.Show("Error al leer el archivo");
            }
        }
    }
}
