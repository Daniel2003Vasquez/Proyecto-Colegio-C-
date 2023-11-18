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
using System.Xml.Linq;

namespace ProyectoTercerCorte
{
    public partial class FormRegistrarEstudiante : Form
    {
        public FormRegistrarEstudiante()
        {
            InitializeComponent();
        }

        public StreamReader Reader { get; set; }
        public StreamWriter Writer { get; set; }
        public string ruta_Estudiante = "datosEstudiante.txt";
        

        public void LimpiarTxt()
        {
            txtNombreE.Text = "";
            txtIdentidicacionE.Text = "";
            DateFechaNacimiento.Text = "";
            txtTelefonoE.Text = "";
            txtCorreoE.Text = "";
            comboGeneroE.Text = "";
        }
        private void FormRegistrarEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarR_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }

        private void btnRegistrarM_Click(object sender, EventArgs e)
        {

            string datosEstudiante = $"{txtNombreE.Text},{txtIdentidicacionE.Text},{DateFechaNacimiento.Text},{txtTelefonoE.Text},{txtCorreoE.Text},{comboGeneroE.Text}";
            if(ValidarEstudiante())
            {
                this.Writer = File.AppendText(ruta_Estudiante);
                this.Writer.WriteLine(datosEstudiante);
                this.Writer.Close();
                LimpiarTxt();
                MessageBox.Show("Registro exitoso");
            }
        }

        public bool ValidarEstudiante()
        {
            long id = long.Parse(txtIdentidicacionE.Text);
            bool validar = true;
            if (File.Exists(ruta_Estudiante))
            {
                Reader = new StreamReader(ruta_Estudiante);
                while(!Reader.EndOfStream) 
                {
                    string[] tem = Reader.ReadLine().Split(',');
                    if (tem[1] == id.ToString())
                    {
                        MessageBox.Show("El id ya se encuentra registrado");
                        LimpiarTxt();
                        validar = false;
                    }
                }
                Reader.Close();
            }
            return validar;
        }

        private void txtIdentidicacionE_Leave(object sender, EventArgs e)
        {
            TextBox textBoxId = (TextBox)sender;
            try
            {
                if (textBoxId.Name.Equals("txtIdentidicacionE"))
                {
                    long.Parse(textBoxId.Text);
                    errorProvider1.SetError(textBoxId, "");
                }
            }
            catch (Exception)
            {
                errorProvider1.SetError(textBoxId, "Ingrese números, no letras");
                textBoxId.Focus();
            }

        }

        private void txtTelefonoE_Leave(object sender, EventArgs e)
        {
            TextBox textBoxPhone = (TextBox)sender;
            try
            {
                if (textBoxPhone.Name.Equals("txtTelefonoE"))
                {
                    long.Parse(textBoxPhone.Text);
                    errorProvider1.SetError(textBoxPhone, "");
                }
            }
            catch (Exception)
            {
                errorProvider1.SetError(textBoxPhone, "Ingrese números, no letras");
                textBoxPhone.Focus();
            }
        }
    }
}
