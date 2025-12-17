using System.Collections;

namespace NetCoreFundamentos
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();
            List<Control> botones = new List<Control>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            botones.Add(this.textBox1);
            botones[0].BackColor = Color.White;


            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);

            ((Button)coleccion[0]).BackColor = Color.Yellow;
            foreach (Button boton in coleccion)
            {
                boton.BackColor = Color.LightBlue;
            }
            coleccion.Add(this.textBox1);
            foreach (Control boton in coleccion)
            {
                boton.BackColor = Color.LightBlue;
                if (boton is TextBox)
                {
                    ((TextBox)boton).Paste();
                }
            }

            this.button1.Click += MetodoDelegado;


            void MetodoDelegado(object sender, EventArgs e)
            {

            }
        }
    }
}
