namespace NetCoreFundamentos
{
    public partial class Form14TiendaProductos : Form
    {
        public Form14TiendaProductos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string itemNuevo = this.txtProducto.Text;
            this.lstTienda.Items.Add(itemNuevo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numElementos = this.lstTienda.SelectedIndices.Count - 1;
            for (int i = numElementos; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();
            //for (int i = 0; i < this.lstTienda.Items.Count; i++)
            //{
            //    this.lstAlmacen.Items.Add()
            //}
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int numElementos = this.lstTienda.SelectedIndices.Count - 1;
            for (int i = 0; i <= numElementos; i++)
            {
                this.lstAlmacen.Items.Add(this.lstTienda.Items[i]);
            }
            int numElementosR = this.lstTienda.SelectedIndices.Count - 1;
            for (int i = numElementosR; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                //this.lstAlmacen.Items.Add(this.lstTienda.Items[index]);
                this.lstTienda.Items.RemoveAt(index);
            }
        }
    }
}
