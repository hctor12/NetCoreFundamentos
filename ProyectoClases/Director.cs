using System.Diagnostics;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor DIRECTOR");
            this.SalarioMinimo += 200;
        }

        public override int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() DIRECTOR");
            return base.GetDiasVacaciones() + 8;
        }


    }
}
