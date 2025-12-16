namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerarNumeros_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //int[] randoms = [];
            for (int i = 0; i < 10; i++)
            {
                int numRandom = rnd.Next(1, 101);
                this.lstNumeros.Items.Add(numRandom);
            }
            //this.lstNumeros.Items.AddRange(randoms);
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (this.lstNumeros.Items.Count < 1)
            {
                return;
            }
            int suma = 0;
            int sumaPares = 0;
            int sumaImpares = 0;

            for (int i = 0; i < this.lstNumeros.Items.Count; i++)
            {
                string numStr = this.lstNumeros.Items[i].ToString();
                int num = int.Parse(numStr);
                suma += num;
                if (num % 2 == 0)
                {
                    sumaPares += num;
                }
                else
                {
                    sumaImpares += num;
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtSumaPares.Text = sumaPares.ToString();
            this.txtSumaImpares.Text = sumaImpares.ToString();
        }
    }
}
