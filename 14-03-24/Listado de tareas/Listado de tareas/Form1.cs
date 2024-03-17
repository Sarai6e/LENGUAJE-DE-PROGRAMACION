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

namespace Listado_de_tareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int f = 1; f <= 96; f++)
            {
                dataGridView1.Rows.Add();

            }
            CargarFecha();
        }

        private void CargarFecha()
        {
            DateTime select = monthCalendar1.SelectionStart;
            label1.Text = "Fecha seleccionada: " + select.ToString("dd/MM/yyyy");
            string fecha = select.Year.ToString() + select.Month.ToString() + select.Day.ToString();

            if (!File.Exists(fecha))
            {
                StreamWriter archivo = new StreamWriter(fecha);
                DateTime fe = DateTime.Today;
                for (int f = 1; f <= 96; f++)
                {
                    archivo.WriteLine(fe.ToString("HH.mm"));
                    archivo.WriteLine(" ");
                    fe = fe.AddMinutes(60);
                }
                archivo.Close();

            }
            StreamReader archivo2 = new StreamReader(fecha);
            int x = 0;
            while (!archivo2.EndOfStream)
            {
                string linea1 = archivo2.ReadLine();
                string linea2 = archivo2.ReadLine();
                dataGridView1.Rows[x].Cells[0].Value = linea1;
                dataGridView1.Rows[x].Cells[1].Value = linea2;
                x++;
            }
            archivo2.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        //funcionabilidades del calendario
            CargarFecha();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DateTime select = monthCalendar1.SelectionStart;
            string fecha = select.Year.ToString() + select.Month.ToString() + select.Day.ToString();
            StreamWriter archivo = new StreamWriter(fecha);
            for (int f = 0; f < dataGridView1.Rows.Count; f++)
            {
                archivo.WriteLine(dataGridView1.Rows[f].Cells[0].Value.ToString());
                if (dataGridView1.Rows[f].Cells[1].Value != null)
                    archivo.WriteLine(dataGridView1.Rows[f].Cells[1].Value.ToString());
                else
                    archivo.WriteLine("");
                ;
            }
            archivo.Close();
        }


    

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         //Booton de eliminar tarea : Elimina las tareas del dia de acuerdo a la fecha 
            DateTime fechaSeleccionada = dateTimePickerVencimiento.Value;
            string fecha = fechaSeleccionada.Year.ToString() + fechaSeleccionada.Month.ToString() + fechaSeleccionada.Day.ToString();

            if (File.Exists(fecha))
            {
                File.Delete(fecha);
                // Actualizar la visualización de las actividades en el DataGridView
                CargarFecha();
            }
            else
            {
                MessageBox.Show("No hay actividades para eliminar en esta fecha.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
        // Booton de tareas pendientes:Muestra las tareas no realizadas

            StringBuilder tareasPendientes = new StringBuilder();
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart;
            string fecha = fechaSeleccionada.Year.ToString() + fechaSeleccionada.Month.ToString() + fechaSeleccionada.Day.ToString();

            if (File.Exists(fecha))
            {
                using (StreamReader archivo = new StreamReader(fecha))
                {
                    string linea;
                    while ((linea = archivo.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linea))
                        {
                            tareasPendientes.AppendLine(archivo.ReadLine());
                        }
                    }
                }
                MessageBox.Show("Tareas pendientes para el día " + fechaSeleccionada.ToString("dd/MM/yyyy") + ":\n\n" + tareasPendientes.ToString());
            }
            else
            {
                MessageBox.Show("No hay tareas pendientes para esta fecha.");
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
        //Booton de exportar tarea : Exporta las tarea que realizaste en un block de notas

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Exportar actividades";
            saveFileDialog.FileName = "actividades_exportadas.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + ": " + dataGridView1.Rows[i].Cells[1].Value.ToString());
                    }
                }
                MessageBox.Show("Actividades exportadas correctamente.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        //Booton de Tareas completadas: Tacha las tareas realizadas

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[rowIndex].DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Strikeout);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }


