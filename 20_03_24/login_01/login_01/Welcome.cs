using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_01
{
    public partial class Welcome : Form
    {
        public Welcome(string nombreUsuario)
        {
            InitializeComponent();

            // Mostrar el mensaje de bienvenida con el nombre de usuario
            labelWelcome.Text = "WELCOME, " + nombreUsuario;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
