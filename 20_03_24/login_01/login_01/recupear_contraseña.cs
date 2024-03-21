using System;
using System.Windows.Forms;

namespace login_01
{
    public partial class recupear_contraseña : Form
    {
        public recupear_contraseña()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Simular el envío de un correo electrónico con un mensaje de confirmación
            string correoElectronico = txtCorreoElectronico.Text;
            if (!string.IsNullOrEmpty(correoElectronico))
            {
                MessageBox.Show($"Se ha enviado un correo electrónico a {correoElectronico} con instrucciones para restablecer la contraseña.", "Correo enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese su correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void recupear_contraseña_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Abrir la ventana "nuevo_usuario"
            Form1 nuevaVentana = new Form1();
            nuevaVentana.Show();
        }
    }
}
