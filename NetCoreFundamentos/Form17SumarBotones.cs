namespace NetCoreFundamentos
{
    public partial class Form17SumarBotones : Form
    {
        List<Button> botones;
        public Form17SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            foreach (Button btn in this.panel1.Controls)
            {
                this.botones.Add(btn);
                btn.Click += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            int numero = int.Parse(botonPulsado.Text);
            int suma = int.Parse(this.txtSuma.Text);
            suma += numero;
            this.txtSuma.Text = suma.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (Button boton in botones)
            {
                int aleat = random.Next(1, 50);
                boton.Text = aleat.ToString();
            }
        }
    }
}
