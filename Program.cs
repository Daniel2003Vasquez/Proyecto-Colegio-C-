using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoTercerCorte
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicio()); //Acordarse de quitarlo. Es mientras se hacen las validaciones

            string ruta_Login = "datosLogin.txt";
            //try
            //{
            //    if (File.Exists(ruta_Login))
            //    {
            //        Application.Run(new FormLogin());
            //    }
            //    else
            //    {
            //        Application.Run(new FormRegistrarUsuarioAdmin());
            //    }

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error al leer los Form\n Revisar << Program >>");
            //}
        }
    }
}
