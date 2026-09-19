namespace Parcial1Lib
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }

        protected Empleado(string nombre, decimal salarioBase)
        {
            Nombre = nombre;
            SalarioBase = salarioBase;
        }
        public abstract string ObtenerInformacion();
        public abstract decimal CalcularSalarioTotal();
    }
}
