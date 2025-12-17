namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        int GetDobleValor(int numero)
        {
            return numero * 2;
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            int resultado = this.GetDobleValor(num);
            this.lblResultado.Text = resultado.ToString();
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.LightBlue;
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnObjetoReferencia);
            this.CambiarColor(this.btnDobleValor);
        }

        void GetDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDobleReferencia(ref num);
            this.lblResultado.Text = num.ToString();
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
