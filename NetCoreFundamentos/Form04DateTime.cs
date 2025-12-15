using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
        }

        private void Form04DateTime_Load(object sender, EventArgs e)
        {
            txtFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void chkFormato_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(txtFechaActual.Text);
            if (chkFormato.Checked)
            {
                txtFechaActual.Text = fecha.ToLongDateString();
            }
            else
            {
                txtFechaActual.Text = fecha.ToShortDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(txtIncremento.Text);
            DateTime fecha = DateTime.Parse(txtFechaActual.Text);
            if (rdbDias.Checked)
            {
                fecha = fecha.AddDays(incremento);
            }
            else if (radioButton1.Checked)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else if (rdbAnyos.Checked)
            {
                fecha = fecha.AddYears(incremento);
            }
            txtFechaFinal.Text = fecha.ToShortDateString();
        }
    }
}
