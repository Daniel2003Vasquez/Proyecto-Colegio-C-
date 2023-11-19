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
    public partial class FormIniciarBoletin : Form
    {
        public FormIniciarBoletin()
        {
            InitializeComponent();
        }

        public StreamReader Reader { get; set; }
        public string ruta_Estudiante = "datosEstudiante.txt"; //Solo para tomar nombre, correo e identificación
        public string ruta_Notas = ""; //Para tomar las notas
        public string ruta_Materias = "datosMaterias.txt"; //Para tomar el nombre y el serial 

        private void FormIniciarBoletin_Load(object sender, EventArgs e)
        {

        }
        long identificacion;
        public bool ValidarEstudianteParaBoletin()
        {
            identificacion = long.Parse(txtIdentificacionB.Text);
            bool validar = true;
            if (File.Exists(ruta_Estudiante))
            {
                Reader = new StreamReader(ruta_Estudiante);
                while (!Reader.EndOfStream)
                {
                    string[] tem = Reader.ReadLine().Split(',');
                    if (tem[1] == identificacion.ToString())
                    {
                        txtIdentificacionB.Text = "";
                        FormBoletin boletin = new FormBoletin(identificacion);
                        boletin.ShowDialog();
                        return validar;
                    }
                }
                Reader.Close();
            }
            return false;
        }

        private void btnRegistrarB_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarEstudianteParaBoletin();
            }
            catch
            {
                MessageBox.Show("Ingrese datos para continuar");
            }
        }
    }
}
