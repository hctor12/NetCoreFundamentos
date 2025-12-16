namespace NetCoreFundamentos
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string ISBN = txtISBN.Text;
            int suma = 0;
            if (ISBN.Length < 10)
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "Error, debe introducir 10 caracteres";
                return;
            }
            char[] arrayChar = ISBN.ToCharArray();
            for (int i = 0; i < ISBN.Length; i++)
            {
                int num = arrayChar[i] * (i + 1);
                suma += num;
            }
            if (suma % 11 == 0)
            {
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = "ISBN Correcto";
            }
            else
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "ISBN Incorrecto";
            }
        }
    }
}
