namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> botones;
        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.botones = new List<CheckBox>();
            foreach (CheckBox item in panel1.Controls)
            {
                CheckBox chk = (CheckBox)item;
                botones.Add(chk);
                chk.CheckedChanged += HandleButton;
            }
        }

        private void HandleButton(object? sender, EventArgs e)
        {
            CheckBox send = (CheckBox)sender;
            int suma = int.Parse(txtSuma.Text);
            if (send.Checked)
            {
                suma += int.Parse(send.Text);
            }
            else
            {
                suma -= int.Parse(send.Text);
            }
            txtSuma.Text = suma.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (CheckBox boton in botones)
            {
                int aleat = random.Next(1, 50);
                boton.Text = aleat.ToString();
            }
        }
    }
}
