using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            //Aqui borramos todo el texto que hubieramos puesto
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            //Aqui se encuentra el boton para guardar datos
            MessageBox.Show("DATOS GUARDADOS");
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //Aqui cerramos el programa
            Close();
        }
    }
}
