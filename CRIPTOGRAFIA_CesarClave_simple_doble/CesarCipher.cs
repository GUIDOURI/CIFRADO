using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRIPTOGRAFIA_CesarClave_simple_doble
{
    public class CesarCipher
    {
        private string keyword;

        public CesarCipher(string keyword)
        {
            this.keyword = keyword;
        }

        // Método para cifrar un texto utilizando el cifrado Cesar con palabra clave
        public string Encrypt(string text)
        {
            string encryptedText = "";
            int keywordIndex = 0;

            // Recorremos cada caracter del texto
            foreach (char c in text)
            {
                // Obtenemos el desplazamiento de la letra de la palabra clave correspondiente
                int keywordOffset = keyword[keywordIndex] - 'a';

                // Ciframos el caracter sumando el desplazamiento
                char encryptedChar = (char)(c + keywordOffset);

                // Si el caracter cifrado excede el rango de letras minúsculas, lo ajustamos
                if (encryptedChar > 'z')
                {
                    encryptedChar = (char)(encryptedChar - 26);
                }

                // Agregamos el caracter cifrado a la cadena resultante
                encryptedText += encryptedChar;

                // Incrementamos el índice de la palabra clave
                keywordIndex++;

                // Si llegamos al final de la palabra clave, volvemos al inicio
                if (keywordIndex == keyword.Length)
                {
                    keywordIndex = 0;
                }
            }

            return encryptedText;
        }

        // Método para descifrar un texto cifrado utilizando el cifrado Cesar con palabra clave
        public string Decrypt(string encryptedText)
        {
            string decryptedText = "";
            int keywordIndex = 0;

            // Recorremos cada caracter del texto cifrado
            foreach (char c in encryptedText)
            {
                // Obtenemos el desplazamiento de la letra de la palabra clave correspondiente
                int keywordOffset = keyword[keywordIndex] - 'a';

                // Desciframos el caracter restando el desplazamiento
                char decryptedChar = (char)(c - keywordOffset);

                // Si el caracter descifrado está antes de 'a', lo ajustamos
                if (decryptedChar < 'a')
                {
                    decryptedChar = (char)(decryptedChar + 26);
                }

                // Agregamos el caracter descifrado a la cadena resultante
                decryptedText += decryptedChar;

                // Incrementamos el índice de la palabra clave
                keywordIndex++;

                // Si llegamos al final de la palabra clave, volvemos al inicio
                if (keywordIndex == keyword.Length)
                {
                    keywordIndex = 0;
                }
            }
            return decryptedText;
        }

    }
}