using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Location = new Point(int.Parse(this.txtPosX.Text), int.Parse(this.txtPosY.Text));
        }

        private void btnCambiarFondo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRojo.Text) || string.IsNullOrEmpty(this.txtVerde.Text) || string.IsNullOrEmpty(this.txtAzul.Text))
            {
                MessageBox.Show("Debe ingresar un valor en los tres colores");
                return;
            }
            if (int.Parse(this.txtRojo.Text) < 0 || int.Parse(this.txtRojo.Text) > 255 ||
                int.Parse(this.txtVerde.Text) < 0 || int.Parse(this.txtVerde.Text) > 255 ||
                int.Parse(this.txtAzul.Text) < 0 || int.Parse(this.txtAzul.Text) > 255)
            {
                MessageBox.Show("Los valores de los colores deben estar entre 0 y 255");
                return;
            }
            this.BackColor = Color.FromArgb(int.Parse(this.txtRojo.Text), int.Parse(this.txtVerde.Text), int.Parse(this.txtAzul.Text));
        }
    }
}
