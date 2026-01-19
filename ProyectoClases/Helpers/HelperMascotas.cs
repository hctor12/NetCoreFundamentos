using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        private HelperFiles helper;
        private string path;

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelperFiles();
            this.path = @"C:\Users\Alumnos MCSD Mañana\Documents\mascotas.txt";
        }

        private void ConvetirMascotasList(string data)
        {
            this.Mascotas.Clear();
            string[] datosMascotas = data.Split('@');
            foreach (string stringMascota in datosMascotas)
            {
                string[] propiedades = stringMascota.Split(',');
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        public async Task ReadMascotasAsync()
        {
            string data = await this.helper.ReadFileAsync(this.path);
            this.ConvetirMascotasList(data);
        }

        private string ConvertirMascotasString()
        {
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                data += propiedades + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }


        public async Task WriteMascotasAsync()
        {
            string data = this.ConvertirMascotasString();
            await this.helper.WriteFileAsync(this.path, data);
        }
    }
}
