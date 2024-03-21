using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login_01
{
    public partial class nuevo_usuario : Form
    {
        // Cadena de conexión a la base de datos
        private string connectionString = @"Data Source=(localdb)\senati;Initial Catalog=LOGIN;Integrated Security=True;";

        public nuevo_usuario()
        {
            InitializeComponent();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Abrir la ventana "nuevo_usuario"
            Form1 nuevaVentana = new Form1();
            nuevaVentana.Show();
        }

        private void nuevo_usuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;
            string confirmarContraseña = txtConfirmarContraseña.Text;
            string numeroCelular = txtNumeroCelular.Text;

            // Validar que se ingresen todos los campos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña) ||
                string.IsNullOrEmpty(confirmarContraseña) || string.IsNullOrEmpty(numeroCelular))
            {
                MessageBox.Show("Por favor complete todos los campos");
                return;
            }

            // Validar que las contraseñas coincidan
            if (contraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            // Insertar en la base de datos
            InsertarUsuario(nombre, apellido, nombreUsuario, contraseña, confirmarContraseña, numeroCelular);

            MessageBox.Show("Usuario registrado correctamente");
        }

        private void InsertarUsuario(string nombre, string apellido, string nombreUsuario, string contraseña, string confirmarContraseña, string numeroCelular)
        {
            // Sentencia SQL para la inserción
            string query = "INSERT INTO registro (nombre, apellido, nombre_de_usuario, contrasena, confirmar_contrasena, numero_de_celular) " +
                           "VALUES (@nombre, @apellido, @nombreUsuario, @contraseña, @confirmarContraseña, @numeroCelular)";

            // Crear conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear comando
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.Parameters.AddWithValue("@confirmarContraseña", confirmarContraseña);
                    command.Parameters.AddWithValue("@numeroCelular", numeroCelular);

                    try
                    {
                        // Abrir conexión
                        connection.Open();

                        // Ejecutar comando
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar usuario: " + ex.Message);
                    }
                }
            }
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            // Cambiar el carácter de contraseña según el estado del CheckBox
            txtContraseña.UseSystemPasswordChar = !checkBoxMostrarContraseña.Checked;
            txtConfirmarContraseña.UseSystemPasswordChar = !checkBoxMostrarContraseña.Checked;
        }
    }
}
