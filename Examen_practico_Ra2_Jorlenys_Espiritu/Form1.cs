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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examen_practico_Ra2_Jorlenys_Espiritu
{
    public partial class Form1 : Form
    {
        DialogResult respuesta;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_matricula.Enabled = true;
            txt_nombre.Enabled = true;
            comboBoxcurso.Enabled = true;
            comboBoxseccion.Enabled = true;
            comboBoxarea.Enabled = true;
            btn_eliminar.Enabled = false;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            btn_guardar.Enabled = false;
            btn_nuevo.Enabled = true;
            btn_agregar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_salir.Enabled = true;

            using (StreamWriter writer = new StreamWriter("datos.txt", true))
            {
        writer.WriteLine($"{txt_matricula.Text},{txt_nombre.Text},{comboBoxcurso.Text}," +
            $"{comboBoxseccion.Text},{comboBoxarea.Text}");
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
        dataGridView1.Rows.Add(txt_matricula.Text, txt_nombre.Text, comboBoxcurso.Text, 
        comboBoxseccion.Text, comboBoxarea.Text,
        txt_direccion.Text, txt_telefono.Text, comboBoxgenero.Text, txt_email.Text,
        txt_maestro.Text
             );

           
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DialogResult result = MessageBox.Show("¿Desea eliminar el registro?", "Confirmar Eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Eliminar la fila seleccionada
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

    }
        

       
    

