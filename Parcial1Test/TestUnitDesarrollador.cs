using Parcial1Lib;

namespace Parcial1Test
{
    [TestClass]
    public class TestUnitDesarrollador
    {
        [TestMethod]
        public void CalcularSalarioTotal_DeberiaSumarSalarioBaseYBono()
        {
            // Arrange
            string nombre = "Carlos Pérez";
            decimal salarioBase = 3000m;
            decimal bono = 500m;
            decimal esperado = 3500m;

            Desarrollador dev = new Desarrollador(nombre, salarioBase, bono);

            // Act
            decimal resultado = dev.CalcularSalarioTotal();

            // Assert
            Assert.AreEqual(esperado, resultado, "El cálculo del salario total.");
        }

        [TestMethod]
        public void ObtenerInformacion_DeberiaRetornarCadenaFormateada()
        {
            // Arrange
            string nombre = "Ana Gómez";
            decimal salarioBase = 4000m;
            decimal bono = 800m;

            Desarrollador dev = new Desarrollador(nombre, salarioBase, bono);

            // Act
            string info = dev.ObtenerInformacion();

            // Assert
            Assert.IsTrue(info.Contains(nombre), "La información debe contener el nombre del desarrollador.");
            Assert.IsTrue(info.Contains("Desarrollador"), "La información debe incluir el rol de Desarrollador.");
        }
    }
}