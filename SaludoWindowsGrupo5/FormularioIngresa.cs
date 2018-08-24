using System;
using System.Windows.Forms;


namespace SaludoWindowsGrupo5
{
   partial class FormularioIngresa
    {
        public FormularioIngresa()
        {
            IniciarComponentes();
        }

        private void btnAceptar_Click(object sender, EventArgs e )
        {
          string nombre= txtbNombre.Text;
            MessageBox.Show("Hola " + nombre,"Saludo");
        }
        
    }
}
