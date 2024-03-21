using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login_01
{
    public partial class Form1 : Form
    {
        // Cadena de conexión a la base de datos
        private string connectionString = @"Data Source=(localdb)\senati;Initial Catalog=LOGIN;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Validar que se ingresen usuario y contraseña
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña");
                return;
            }

            // Insertar en la base de datos
            InsertarUsuario(usuario, contraseña);

            // Mostrar mensaje de éxito
            MessageBox.Show("Usuario ingresado correctamente");

            // Abrir la ventana de bienvenida con el nombre de usuario
            Welcome welcomeWindow = new Welcome(usuario);
            welcomeWindow.Show();
        }






        private void InsertarUsuario(string usuario, string contraseña)
        {
            // Sentencia SQL para la inserción
            string query = "INSERT INTO login_01 (nombre_de_usuario, contrasena) VALUES (@usuario, @contrasena)";

            // Crear y abrir conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contrasena", contraseña);

                    try
                    {
                        // Abrir conexión
                        connection.Open();

                        // Ejecutar comando
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar usuario: " + ex.Message);
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Este método se ejecutará cada vez que cambie el texto en el textBox2
            // Puedes agregar lógica aquí si necesitas hacer algo específico cuando cambia el texto
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Abrir la ventana "nuevo_usuario"
            nuevo_usuario nuevaVentana = new nuevo_usuario();
            nuevaVentana.Show();
        }

        private void checkBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar u ocultar la contraseña según el estado del CheckBox
            txtContraseña.UseSystemPasswordChar = !checkBoxMostrarContraseña.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Abrir la ventana "nuevo_usuario"
            recupear_contraseña nuevaVentana = new recupear_contraseña();
            nuevaVentana.Show();
        }
    }
    }

