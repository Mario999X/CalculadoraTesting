using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CalculadoraApp.Calculadora
{
    [TestClass]
    public class CalculadoraTestsMock
    {
        private Mock<Calculadora> c;

        private Servicio s;

        [TestInitialize]
        public void Init()
        {
            c = new();
            s = new(c.Object);
        }

        [TestMethod]
        public void SumaServicio()
        {
            c.Setup(x => x.Suma(It.IsAny<int>(), It.IsAny<int>())).Returns(2);
            var res = s.Suma("1", "1");

            Assert.AreEqual(2, res);

           c.Verify(x => x.Suma(It.IsAny<int>(), It.IsAny<int>()));
        }

        // No entra en el metodo original, asi que no se mockea.
        [TestMethod]
        public void SumaServicioNull()
        {
            var res = s.Suma("a", "1");

            Assert.IsNull(res);
        }

        [TestMethod]
        public void RestaServicio()
        {
            c.Setup(x => x.Resta(It.IsAny<int>(), It.IsAny<int>())).Returns(2);
            var res = s.Resta("3", "1");

            Assert.AreEqual(2, res);

            c.Verify(x => x.Resta(It.IsAny<int>(), It.IsAny<int>()));
        }        
        
        [TestMethod]
        public void RestaServicioNull()
        {
            var res = s.Resta("a", "1");

            Assert.IsNull(res);
        }

        [TestMethod]
        public void MultiplicarServicio()
        {
            c.Setup(x => x.Multiplicar(It.IsAny<int>(), It.IsAny<int>())).Returns(2);

            var res = s.Multiplicar("2", "1");

            Assert.AreEqual(2, res);

            c.Verify(x => x.Multiplicar(It.IsAny<int>(), It.IsAny<int>()));
        }
        
        [TestMethod]
        public void MultiplicarServicioNull()
        {
            var res = s.Multiplicar("a", "1");

            Assert.IsNull(res);
        }

        [TestMethod]
        public void DividirServicio()
        {
            c.Setup(x => x.Dividir(It.IsAny<int>(), It.IsAny<int>())).Returns(3);
            var res = s.Dividir("3", "1");

            Assert.AreEqual(3, res);

            c.Verify(x => x.Dividir(It.IsAny<int>(), It.IsAny<int>()));
        }

        [TestMethod]
        public void DividirServicioWith0()
        {
            c.Setup(x => x.Dividir(It.IsAny<int>(), It.IsAny<int>())).Returns(value: null);
            var res = s.Dividir("3", "0");

            Assert.IsNull(res);

            c.Verify(x => x.Dividir(It.IsAny<int>(), It.IsAny<int>()));
        }

        [TestMethod]
        public void DividirServicioNull()
        {
            var res = s.Dividir("a", "1");

            Assert.IsNull(res);

        }

        
    }
}
