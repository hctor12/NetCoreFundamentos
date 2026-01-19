using ProyectoClases.Helpers;
using ProyectoClases.Models;

namespace NetCoreFundamentos
{
    public partial class Form22MascotasFiles : Form
    {
        HelperMascotas helper;
        public Form22MascotasFiles()
        {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }


        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            await this.helper.WriteMascotasAsync();
            this.lstMascotas.Items.Clear();
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.Raza = txtRaza.Text;
            this.helper.Mascotas.Add(mascota);
            this.DibujarMascotas();

        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            await this.helper.ReadMascotasAsync();
            this.DibujarMascotas();
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;
            if (index != -1)
            {
                Mascota mascota = this.helper.Mascotas[index];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
            }

        }
    }
}
