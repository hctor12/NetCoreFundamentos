namespace ProyectoClases
{
    public class FacturaEnero : IFactura
    {
        public int PrecioBase { get; set; }
        public int PrecioTotal { get; set; }

        public void CalcularIva()
        {
            throw new NotImplementedException();
        }

        public void OdioHacienda(int mucho)
        {
            throw new NotImplementedException();
        }
    }
}
