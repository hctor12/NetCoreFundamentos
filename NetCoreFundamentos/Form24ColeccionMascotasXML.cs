using ProyectoClases.Models;
using System.Xml.Serialization;

namespace NetCoreFundamentos
{
    public partial class Form24ColeccionMascotasXML : Form
    {
        XmlSerializer serializer;
        ColeccionMascotas mascotasList;
        public Form24ColeccionMascotasXML()
        {
            InitializeComponent();
            serializer = new XmlSerializer(typeof(ColeccionMascotas));
            mascotasList = new ColeccionMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.mascotasList)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);
            mascota.Imagen = ConvertImageToByteArray(this.pictureBox1.ImageLocation);
            this.mascotasList.Add(mascota);
            this.DibujarMascotas();
            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtEdad.Clear();
        }

        private byte[] ConvertImageToByteArray(string imagePath)
        {
            // Abre el archivo en modo binario para lectura
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                // Crea un BinaryReader para leer los datos binarios
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    // Lee todos los bytes del archivo
                    byte[] imageBytes = reader.ReadBytes((int)fs.Length);
                    return imageBytes;
                }
            }
        }

        private void btnLeerMascotas_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\Alumnos MCSD Mañana\Documents\listaMascotas.txt"))
            {
                this.mascotasList = (ColeccionMascotas)this.serializer.Deserialize(reader);
                reader.Close();
                this.DibujarMascotas();
            }
        }

        private async void btnGuardarMascotas_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Alumnos MCSD Mañana\Documents\listaMascotas.txt"))
            {
                this.serializer.Serialize(writer, this.mascotasList);
                await writer.FlushAsync();
                writer.Close();
                this.lstMascotas.Items.Clear();
                this.mascotasList.Clear();
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;
            if (index != -1)
            {
                Mascota mascota = this.mascotasList[index];
                txtNombre.Text = mascota.Nombre;
                txtRaza.Text = mascota.Raza;
                txtEdad.Text = mascota.Edad.ToString();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string path = this.openFileDialog1.FileName;
            this.pictureBox1.ImageLocation = path;
            this.pictureBox1.Image = Image.FromFile(path);
        }
    }
}
