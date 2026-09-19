namespace Parcial1Lib
{
    public class Gerente : Empleado
    {
        public decimal Comision { get; set; }

        public Gerente(string nombre, decimal salarioBase, decimal comision)
            : base(nombre, salarioBase)
        {
            Comision = comision;
        }

        public override decimal CalcularSalarioTotal()
        {
            return SalarioBase + Comision;
        }

        public override string ObtenerInformacion()
        {
            return $"Gerente: {Nombre} | Salario Base: {SalarioBase:C} | Comisión: {Comision:C} | Total: {CalcularSalarioTotal():C}";
        }
    }
}