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
    public partial class FormVerTodasLasNotas : Form
    {
        public FormVerTodasLasNotas()
        {
            InitializeComponent();
        }
        public StreamReader Reader { get; set; }

        private void FormVerTodasLasNotas_Load(object sender, EventArgs e)
        {
            string ruta = "datosMaterias.txt"; //ruta materia
            string ruta_2 = "NotasDatoStudent"; //ruta notas
            //Reader = new StreamReader(ruta);

            //Reader.Close();
        }
    }
}
