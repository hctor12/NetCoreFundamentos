using System.Diagnostics;

namespace ProyectoClases
{
    public class Direccion
    {
        #region PROPIEDADES
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }
        #endregion

        #region CONSTRUCTORES
        public Direccion()
        {
            Debug.WriteLine("Constructor sin parámetros");
        }

        public Direccion(string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor DIRECCION con dos parámetros");
        }

        public Direccion(string calle, string ciudad, int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor DIRECCION con tres parámetros");
        }
        #endregion
    }
}
