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
    public partial class FormComplementoRNotas : Form
    {
        public StreamReader Reader { get; set; }
        public StreamWriter Writer { get; set; }
        private long NumeroCedula;
        string rutaNotasEstudiante = "NotasDatoStudent.txt";
        public FormComplementoRNotas(long cedula)
        {
            InitializeComponent();
            NumeroCedula = cedula;
        }

        private void FormNotasLabel_Load(object sender, EventArgs e)
        {
            try
            {
                string ruta = "datosMaterias.txt";

                string[] lineas = File.ReadAllLines(ruta);

                Label[] nombreMaterias = { lbNota1, LbNota2, LbNota3, LbNota4, LbNota5, LbNota6 };

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
        public void LimpiartxtNotasE()
        {
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
            txtNota4.Text = string.Empty;
            txtNota5.Text = string.Empty;
            txtNota6.Text = string.Empty;
        }
        private void btnRegistrarNE_Click(object sender, EventArgs e)
        {
            try
            {
                long definitiva = (long.Parse(txtNota1.Text) + long.Parse(txtNota2.Text) + long.Parse(txtNota3.Text) + long.Parse(txtNota4.Text) + long.Parse(txtNota5.Text) + long.Parse(txtNota6.Text)) / 6  ; 
                string datosNotas = $"{NumeroCedula},{txtNota1.Text},{txtNota2.Text},{txtNota3.Text},{txtNota4.Text},{txtNota5.Text},{txtNota6.Text},{definitiva}";
                this.Writer = File.AppendText(rutaNotasEstudiante);
                this.Writer.WriteLine(datosNotas);
                this.Writer.Close();
                LimpiartxtNotasE();
                MessageBox.Show("Registro exitoso\n" + $"Su promedio es de: {definitiva}");
            }
            catch
            {
                MessageBox.Show("Error al guardar el archivo");
            }
        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNota1_Leave(object sender, EventArgs e)
        {
            TextBox textBoxNota = (TextBox)sender;
            try
            {
                if (textBoxNota.Name.Equals("txtNota1"))
                {
                    long.Parse(textBoxNota.Text);
                    errorProvider1.SetError(textBoxNota, "");
                }
                if (textBoxNota.Name.Equals("txtNota2"))
                {
                    long.Parse(textBoxNota.Text);
                    errorProvider1.SetError(textBoxNota, "");
                }
                if (textBoxNota.Name.Equals("txtNota3"))
                {
                    long.Parse(textBoxNota.Text);
                    errorProvider1.SetError(textBoxNota, "");
                }
                if (textBoxNota.Name.Equals("txtNota4"))
                {
                    long.Parse(textBoxNota.Text);
                    errorProvider1.SetError(textBoxNota, "");
                }
                if (textBoxNota.Name.Equals("txtNota5"))
                {
                    long.Parse(textBoxNota.Text);
                    errorProvider1.SetError(textBoxNota, "");
                }
                if (textBoxNota.Name.Equals("txtNota6"))
                {
                    long.Parse(textBoxNota.Text);
                    errorProvider1.SetError(textBoxNota, "");
                }

            }
            catch
            {
                errorProvider1.SetError(textBoxNota, "Ingrese números");
                textBoxNota.Focus();
            }
        }
    }
}
