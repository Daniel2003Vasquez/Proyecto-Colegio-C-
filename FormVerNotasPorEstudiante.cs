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
    public partial class FormVerNotasPorEstudiante : Form
    {
        public FormVerNotasPorEstudiante()
        {
            InitializeComponent();
        }
        public long id;
        public string ruta_Estudiante = "NotasDatoStudent.txt";

        public bool ExistStudent()
        {
            id = long.Parse(txtIdentificacionVNE.Text);
            string[] linea = File.ReadAllLines(ruta_Estudiante);
            foreach (string student in linea)
            {
                string[] detalles = student.Split(',');
                if (detalles[0] == id.ToString())
                {
                    return true;
                }
            }
            MessageBox.Show("El id no se encuentra registrado o no ha recibido notas");
            txtIdentificacionVNE.Text = "";
            return false;
        }


        private void FormVerNotasPorEstudiante_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrarM_Click(object sender, EventArgs e)
        {
            try
            {
                bool validar = true;
                if (ExistStudent() == validar)
                {
                    txtIdentificacionVNE.Text = "";
                    FormComplementoVerNotasEstudiante formComplementoVerNotasEstudiante = new FormComplementoVerNotasEstudiante(id);
                    formComplementoVerNotasEstudiante.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese una identificación para buscar ");
            }
        }

        private void txtIdentificacionVNE_Leave(object sender, EventArgs e)
        {
            TextBox textBoxIdentificacion = (TextBox)sender;
            try
            {
                if (textBoxIdentificacion.Name.Equals("txtIdentificacionVNE"))
                {
                    long.Parse(textBoxIdentificacion.Text);
                    errorProvider1.SetError(textBoxIdentificacion, "");
                }
            }
            catch
            {
                errorProvider1.SetError(textBoxIdentificacion, "Ingrese números, no letas");
                textBoxIdentificacion.Focus();
            }
        }
    }
}
