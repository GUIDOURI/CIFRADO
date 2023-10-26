using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRIPTOGRAFIA_CesarClave_simple_doble;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRIPTOGRAFIA_CesarClave_simple_doble.Tests
{
    [TestClass()]
    public class CesarCipherTests
    {
        

        [TestMethod()]
        public void CifrarTest()
        {           
                // Arrange
                string mensaje = "hola mundo soy rodrigo";
                string keyword = "rodrigo";
                CesarCipher cesarCipher = new CesarCipher(keyword);

                string cifrado = cesarCipher.Cifrar(mensaje);
                Assert.AreEqual("ycor uabuc vfg xcuflxw", cifrado);                                     
            
        }

        [TestMethod()]
        public void DescifrarTest()
        {
            // Arrange
            string textoCifrado = "ycor uabuc vfg xcuflxw";
            string keyword = "rodrigo"; // Asegúrate de usar la misma clave que usaste para cifrar.
            CesarCipher cesarCipher = new CesarCipher(keyword);

            // Act
            string descifrado = cesarCipher.Descifrar(textoCifrado);

            // Assert
            // Reemplaza "resultadoEsperado" con el valor descifrado esperado.
            Assert.AreEqual("hola mundo soy rodrigo", descifrado);
        }
    }
}