using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraApp.Calculadora
{
    [TestClass]
    public class CalculadoraTests
    {
        private Calculadora Calculadora;
        private readonly int Num1 = 3;
        private readonly int Num2 = 17;
        private readonly int Num3 = 0;

        [TestInitialize]
        public void Init()
        {
            Calculadora = new Calculadora();
        }

        [TestMethod]
        public void Suma()
        {
            var result = Calculadora.Suma(Num1, Num2);

            Assert.AreEqual(20, result);
        }
        
        [TestMethod]
        public void Resta()
        {
            var result = Calculadora.Resta(Num2, Num1);

            Assert.AreEqual(14, result);
        }
        
        [TestMethod]
        public void Multiplicar()
        {
            var result = Calculadora.Multiplicar(Num1, Num3);

            Assert.AreEqual(0, result);
        }        
        
        [TestMethod]
        public void Dividir()
        {
            var result = Calculadora.Dividir(Num1, Num1);

            Assert.AreEqual(1, result);
        }
        
        [TestMethod]
        public void DividirWithNull()
        {
            var result = Calculadora.Dividir(Num1, Num3);

            Assert.AreEqual(null, result);
        }
    }
}