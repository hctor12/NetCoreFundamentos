namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "NetCore Fundamentos - Héctor";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtNombre.Location = new Point(10, 30);
            this.txtNombre.Text = "Soy un texto nuevo!!!";
            txtNombre.Width = 220;
            txtNombre.BackColor = Color.Fuchsia;
        }
    }
}
