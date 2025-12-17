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

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstAlmacen.SelectedIndex;
            if (selectedIndex > 0)
            {
                object item = lstAlmacen.Items[selectedIndex];
                this.lstAlmacen.Items.RemoveAt(selectedIndex);
                this.lstAlmacen.Items.Insert(selectedIndex - 1, item);
            }

        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstAlmacen.SelectedIndex;
            if (selectedIndex > 0)
            {
                this.btnSubir.Enabled = true;
            }
            else
            {
                this.btnSubir.Enabled = false;
            }
            if (selectedIndex == (this.lstAlmacen.Items.Count - 1))
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstAlmacen.SelectedIndex;
            if (selectedIndex != -1)
            {
                object item = lstAlmacen.Items[selectedIndex];
                this.lstAlmacen.Items.RemoveAt(selectedIndex);
                this.lstAlmacen.Items.Insert(selectedIndex + 1, item);
            }
        }
    }
}
