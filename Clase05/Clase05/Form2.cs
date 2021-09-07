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
    public partial class Form2 : Form
    {
        public Form2(string titulo, string mensaje)
        {
            InitializeComponent();
            //Recibo los datos e inicializo los campos
            lblTitulo.Text = titulo;
            lblMensaje.Text = mensaje;
        }


    }
}
