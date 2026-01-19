using ProyectoClases.Helpers;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
        public string Path { get; set; }
        HelperFiles helper;
        public Form21Files()
        {
            InitializeComponent();
            this.Path = @"C:\Users\Alumnos MCSD Mañana\Documents\file1.txt";
            this.helper = new HelperFiles();

        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            //FileInfo file = new FileInfo(this.Path);
            //using (TextWriter writer = file.CreateText())
            //{
            //    string content = GetNombresListBox();
            //    await writer.WriteAsync(content);
            //    await writer.FlushAsync();
            //    MessageBox.Show("Fichero almacenado");
            //}

            string content = this.GetNombresListBox();
            await this.helper.WriteFileAsync(this.Path, content);
            MessageBox.Show("Datos almacenados");
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnLeerFile_Click(object sender, EventArgs e)
        {
            //FileInfo file = new FileInfo(this.Path);
            //using (TextReader reader = file.OpenText())
            //{
            //    string content = await reader.ReadToEndAsync();
            //    this.txtContenido.Text = content;
            //}

            string content = await this.helper.ReadFileAsync(this.Path);
            this.txtContenido.Text = content;
            string[] nombres = content.Split(',');
            this.lstNombres.Items.Clear();
            foreach (string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }
    }
}
