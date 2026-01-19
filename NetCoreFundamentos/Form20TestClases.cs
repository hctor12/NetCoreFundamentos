using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.Nombre = "Alumno";
            person.Apellidos = "Reyes";
            person.Edad = 25;
            person.Genero = (TipoGenero)1;
            person.Nacionalidad = Paises.Andorra;
            person.Domicilio = new Direccion("Avenida Enero", "Madrid", 28003);
            person[0] = "Vamos 1";
            person[1] = "Vamos 1";
            this.lstClases.Items.Add("Nombre: " + person.Nombre + ", " + "Apellidos: "
                + person.Apellidos + ", " + "Edad: " + person.Edad + ", Género: "
                + person.Genero + ", " + "Nacionalidad: " + person.Nacionalidad);
            this.lstClases.Items.Add(person.GetNombreCompleto(true));
            this.lstClases.Items.Add("Dirección: " + person.Domicilio.Calle + ", " + person.Domicilio.Ciudad + ", " + person.Domicilio.CodigoPostal);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //Empleado emp = new Empleado("Nombre", "Apellidos");
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Becario";
            //emp.SalarioMinimo = 4000;
            this.lstClases.Items.Add("Vacas Empleado: " + emp.GetDiasVacaciones());
            this.lstClases.Items.Add("Empleado: " + emp.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + emp.GetSalarioMinimo() + "€");

            Director dr = new Director();
            dr.Nombre = "Director";
            dr.Apellidos = "Director";
            this.lstClases.Items.Add("Vacas Director: " + dr.GetDiasVacaciones());
            this.lstClases.Items.Add("Empleado: " + dr.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + dr.GetSalarioMinimo() + "€");
        }
    }
}
