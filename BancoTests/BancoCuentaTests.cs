using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebasUnitariasSantander;

namespace BancoTests
{
    [TestClass]
    public class BancoCuentaTests
    {
        [TestMethod]
        public void Debito_ActualizaBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            CuentaBancaria cuenta = new CuentaBancaria("Pako Leal Curiel", beginningBalance);

            // Act
            cuenta.Debito(debitAmount);

            // Assert
            double actual = cuenta.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Cuenta No debitada correctamente");
         //   Assert.IsTrue(expected > debitAmount);
        }
    }
}
