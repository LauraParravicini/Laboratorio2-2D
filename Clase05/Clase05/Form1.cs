using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mensaje = $"{txtNombre.Text} - {txtApellido.Text}"; 
            //Al hacer click instancio un objeto de tipo formulario que quiero mostrar despues y en forma de pop up
            Form2 saludar = new Form2("Hola Windows Form!",mensaje);
            saludar.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
