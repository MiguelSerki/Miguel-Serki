using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Test;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void ProbarSuma()
        {
            Console.WriteLine("This should fail");
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var suma = calculadora.Agregar(10, 60);

            //Assert
            Assert.IsInstanceOfType(suma, typeof(int));
            Assert.AreEqual(70, suma);
        }

        [TestMethod]
        public void ProbarRestaDebeDevolverEntero()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resta = calculadora.Restar(10, 60);

            //Assert
            Assert.IsInstanceOfType(resta, typeof(int));
            Assert.AreEqual(-50, resta);
        }

        [TestMethod]
        public void ProbarMultiplicar()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var multiplicar = calculadora.Multiplicar(4, 3);

            //Assert
            Assert.IsInstanceOfType(multiplicar, typeof(int));
            Assert.AreEqual(12, multiplicar);
        }

        [TestMethod]
        public void ProbarDivision()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var division = calculadora.Dividir(10, 5);

            //Assert
            Assert.IsInstanceOfType(division, typeof(decimal));
            Assert.AreEqual(2, division);
        }

        [TestMethod]
        public void ProbarQue2Mas2Es4()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var suma = calculadora.Agregar(2, 2);

            //Assert
            Assert.IsInstanceOfType(suma, typeof(int));
            Assert.AreEqual(4, suma);
        }

        [TestMethod][ExpectedException(typeof(DivideByZeroException))]
        public void ProbarDividirPorCero()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var division = calculadora.Dividir(4, 0);

            //Assert
        }
    }
}
