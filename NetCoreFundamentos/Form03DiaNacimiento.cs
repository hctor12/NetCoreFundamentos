using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anio = int.Parse(this.txtAnio.Text);

            //Calcular el día de la semana en español
            //DateTime fecha = new DateTime(anio, mes, dia);
            //string diaSemana = fecha.ToString("dddd", new System.Globalization.CultureInfo("es-ES")).ToUpper();
            //lblResultado.Text = "El día de la semana es " + diaSemana;

            if (mes ==  1)
            {
                mes = 12;
                anio -= 1;
            }
            if(mes == 2)
            {
                mes = 13;
                anio -= 1;
            }

            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anio / 4;
            int op3 = anio / 100;
            int op4 = anio / 400;
            int op5 = dia + (mes * 2) + anio + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int diaSemanaNum = op5 - (op6 * 7);
            string[] diasSemana = { "SÁBADO", "DOMINGO", "LUNES", "MARTES", "MIÉRCOLES", "JUEVES", "VIERNES" };
            string diaSemana = diasSemana[diaSemanaNum];
            lblResultado.Text = "El día de la semana es " + diaSemana;
        }
    }
}
