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
    public class TranspositionCipherTests
    {
        [TestMethod()]
        public void EncryptTest()
        {
            string message = "Hola mundo";
            string key = "guido";
            string expected = "Hmoulnad o";

            // Act
            string result = TranspositionCipher.Encrypt(message, key);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void DecryptTest()
        {
            string cipherText = "Hmoulnad o";
            string key = "guido";
            string expected = "Hola mundo";

            string result = TranspositionCipher.Decrypt(cipherText, key);
            Assert.AreEqual(expected, result);
        }
      
        [TestMethod()]
        public void Encrypt2Test()
        {
            string message = "Hola mundo";
            string key = "12345";

           
            string encryptedMessage = TranspositionCipher.Encrypt2(message, key);
            Assert.AreEqual("Hmoulnad o", encryptedMessage);
        }

        [TestMethod()]
        public void Decrypt2Test()
        {
            string cipherText = "Hmoulnad o";
            string key = "12345"; 
            
            string decryptedMessage = TranspositionCipher.Decrypt2(cipherText, key);       
            Assert.AreEqual("Holamundo", decryptedMessage);
        }
    }

}