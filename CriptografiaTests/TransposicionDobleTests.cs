using Microsoft.VisualStudio.TestTools.UnitTesting;
using Criptografia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Criptografia.Tests
{
    [TestClass()]
    public class TransposicionDobleTests
    {
         

        [TestMethod]
        public void TestCifrar()
        {
            
            var transposicionDoble = new TransposicionDoble();
            var mensaje = "HolaMundo";
            var esperado = "HlMnooaud";

           
            var resultado = transposicionDoble.Cifrar(mensaje);

            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestDescifrar()
        {
            
            var transposicionDoble = new TransposicionDoble();
            var mensajeCifrado = "HlMnooaud";
            var esperado = "HolaMundo";

           
            var resultado = transposicionDoble.Descifrar(mensajeCifrado);

            
            Assert.AreEqual(esperado, resultado);
        }

        [TestClass()]
        public class CriptografiaTests
        {
            [TestMethod()]
            public void GuardarComoTextoTest()
            {
                
                string contenido = "Este es un mensaje de prueba.";
                string nombreArchivo = "test.txt";

                
                bool resultado = Criptografia.GuardarComoTexto(contenido, nombreArchivo);

                
                Assert.IsTrue(resultado);
                Assert.IsTrue(File.Exists(nombreArchivo));
            }

            [TestMethod()]
            public void AbrirComoTextoTest()
            {
                
                string nombreArchivo = "test.txt";

                
                string resultado = Criptografia.AbrirComoTexto(nombreArchivo);

                
                Assert.IsFalse(string.IsNullOrWhiteSpace(resultado));
            }
        }
    }

}
