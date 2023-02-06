using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;


namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void validarMetodoIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void validarMetodoIngreso1()
        {
            // preparación del caso de prueba
            double saldoInicial = 0;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void validarMetodoIngreso3()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 0;
            double saldoActual = 0;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void validarMetodoIngreso5()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 100;
            double saldoActual = -1;
            double saldoEsperado = 1100;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void validarMetodoIngreso6()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 100;
            double saldoActual = -1;
            double saldoEsperado = 1100;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void validarMetodoIngreso7()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 100;
            double saldoActual = 9;
            double saldoEsperado = 1100;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void validarMetodoIngreso8()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 100;
            double saldoActual = 9;
            double saldoEsperado = 1100;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void validarMetodoIngreso9()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 100;
            double saldoActual = 1100;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
    }
    [TestClass]
    public class gestionBancariaTestsIngreso
    {
        [TestMethod]
        public void validarMetodoReintegro()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 100;
            double saldoActual = 1100;
            double saldoEsperado = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void validarMetodoReintegro1()
        {
            // preparación del caso de prueba
            double saldoInicial = 0;
            double reintegro = 100;
            double saldoActual = 1100;
            double saldoEsperado = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void validarMetodoReintegro2()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = -1;
            double saldoActual = 1100;
            double saldoEsperado = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void validarMetodoReintegro3()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 1100;
            double saldoActual = 1100;
            double saldoEsperado = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void validarMetodoReintegro4()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 100;
            double saldoActual = -1;
            double saldoEsperado = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void validarMetodoReintegro5()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 100;
            double saldoActual = 9;
            double saldoEsperado = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void validarMetodoReintegro6()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 100;
            double saldoActual =900;
            double saldoEsperado = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

    }
}