namespace NetCoreFundamentos
{
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim('@');
            //Comporbar si el email contiene solo una arroba y un punto después de la arroba y un dominio de 2 a 3 caracteres

            if (email.Length == 0)
            {
                lblResultado.Text = "El email no puede estar vacío";
                lblResultado.ForeColor = Color.Red;
                return;
            }
            int arrobaIndex = email.IndexOf('@');
            int lastArrobaIndex = email.LastIndexOf('@');
            if (arrobaIndex == -1 || arrobaIndex != lastArrobaIndex)
            {
                lblResultado.Text = "El email es inválido";
                lblResultado.ForeColor = Color.Red;
                return;
            }
            int puntoIndex = email.IndexOf('.', arrobaIndex);
            if (puntoIndex == -1)
            {
                lblResultado.Text = "El email es inválido";
                lblResultado.ForeColor = Color.Red;
                return;
            }
            string dominio = email.Substring(puntoIndex + 1);
            if (dominio.Length < 2 || dominio.Length > 3)
            {
                lblResultado.Text = "El email es inválido";
                lblResultado.ForeColor = Color.Red;
                return;
            }
            lblResultado.ForeColor = Color.Green;
            lblResultado.Text = "El email es válido";
        }
    }
}
