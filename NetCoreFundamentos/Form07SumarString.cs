namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtInput.Text;
            int suma = 0;
            for (int i = 0; i < textoNumeros.Length; i++)
            {
                char c = textoNumeros[i];
                if (char.IsDigit(c))
                {
                    suma += (int)char.GetNumericValue(c);
                }
            }
            lblResultado.Text = $"La suma de {textoNumeros} es {suma}";
        }
    }
}
