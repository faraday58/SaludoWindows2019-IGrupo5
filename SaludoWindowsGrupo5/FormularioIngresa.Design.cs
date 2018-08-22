using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaludoWindowsGrupo5
{
    partial class FormularioIngresa:Form
    {
        #region Atributos
        private Label etIngresaNombre;
        private TextBox txtbNombre;
        private Button btnAceptar;
        #endregion
        #region Métodos de inicio
        public void IniciarComponentes()
        {

            //Asignando valores a los atributos del formulario contenedor
            this.ClientSize = new Size(300, 200);
            this.Text = "Formulario de Bienvenida";
            this.StartPosition = FormStartPosition.CenterScreen;

            //Construccción de valores a los atributos contenidos en la ventana
            etIngresaNombre = new Label();
            etIngresaNombre.Text = " Ingresa tu nombre ";
            etIngresaNombre.TextAlign = ContentAlignment.MiddleCenter;
            etIngresaNombre.Location = new Point(10, 20);
            etIngresaNombre.Size = new Size(180, 35);
            etIngresaNombre.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            //Construcción del Textbox
            txtbNombre = new TextBox();
            txtbNombre.TextAlign = HorizontalAlignment.Left;
            txtbNombre.Location = new Point(20, 70);
            txtbNombre.Size = new Size(200, 20);

            //Construcción del Botón

            btnAceptar = new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleCenter;
            btnAceptar.Location = new Point(30, 100);
            btnAceptar.Size = new Size(100, 20);
            btnAceptar.BackColor = Color.Cyan;

            this.Controls.Add(etIngresaNombre);
            this.Controls.Add(txtbNombre);
            this.Controls.Add(btnAceptar);


        }
        #endregion
    }
}
