namespace NetCoreFundamentos
{
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nuevoElemento = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(nuevoElemento);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int itemSeleccionadoIndex = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(itemSeleccionadoIndex);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndex.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblItem.Text = this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}
