namespace Parcial1Lib
{
    public class Desarrollador : Empleado
    {
        public decimal BonoProductividad { get; set; }

        public Desarrollador(string nombre, decimal salarioBase, decimal bonoProductividad)
            : base(nombre, salarioBase)
        {
            BonoProductividad = bonoProductividad;
        }

        public override decimal CalcularSalarioTotal()
        {
            return SalarioBase + BonoProductividad;
        }

        public override string ObtenerInformacion()
        {
            return $"Desarrollador: {Nombre} | Salario Base: {SalarioBase:C} | Bono: {BonoProductividad:C} | Total: {CalcularSalarioTotal():C}";
        }
    }
}