namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<Button> botones;
        List<TextBox> txts;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.txts = new List<TextBox>();
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    botones.Add((Button)control);
                    control.Click += handleButton;
                }
                else if (control is TextBox)
                {
                    txts.Add((TextBox)control);
                }

            }
        }

        private void handleButton(object? sender, EventArgs e)
        {
            Button send = (Button)sender;
            int num = int.Parse(send.Text);
            int contador = 0;

            for (int i = txts.Count - 1; i >= 0; i--)
            {
                txts[i].Text = (num * (contador + 1)).ToString();
                contador++;
            }
        }
    }
}
