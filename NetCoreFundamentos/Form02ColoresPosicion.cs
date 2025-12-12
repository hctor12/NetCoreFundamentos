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
            this.BackColor = Color.FromArgb(int.Parse(this.txtRojo.Text), int.Parse(this.txtVerde.Text), int.Parse(this.txtAzul.Text));
        }
    }
}
