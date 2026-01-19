using System.Diagnostics;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        #region PROPIEDADES
        protected int SalarioMinimo { get; set; }
        #endregion

        #region CONSTRUCTORES

        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacío");
            this.SalarioMinimo = 1600;
        }

        public Empleado(string nombre, string apellidos) : base(nombre, apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor EMPLEADO con dos parámetros");
        }

        public Empleado(string nombre, string apellidos, int edad) : base(nombre, apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            Debug.WriteLine("Constructor EMPLEADO con tres parámetros");
        }
        #endregion

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }
    }
}
