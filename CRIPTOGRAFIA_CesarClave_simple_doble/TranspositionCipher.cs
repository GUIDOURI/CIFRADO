using Criptografia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRIPTOGRAFIA_CesarClave_simple_doble
{
    public static class TranspositionCipher
    {
        public static string Encrypt(string message, string key)
        {
            int keyLength = key.Length;
            int messageLength = message.Length;

            // Calcular el número de filas necesario en la matriz de cifrado
            int numRows = (int)Math.Ceiling((double)messageLength / keyLength);

            // Crear una matriz para almacenar los caracteres del mensaje
            char[,] matrix = new char[numRows, keyLength];

            // Llenar la matriz con el mensaje original
            int messageIndex = 0;
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < keyLength; col++)
                {
                    if (messageIndex < messageLength)
                    {
                        matrix[row, col] = message[messageIndex];
                        messageIndex++;
                    }
                    else
                    {
                        matrix[row, col] = ' '; // Rellenar con espacios si es necesario
                    }
                }
            }

            // Construir el mensaje cifrado
            StringBuilder encryptedMessage = new StringBuilder();
            for (int col = 0; col < keyLength; col++)
            {
                int order = key.IndexOf(key[col]);
                for (int row = 0; row < numRows; row++)
                {
                    encryptedMessage.Append(matrix[row, order]);
                }
            }

            return encryptedMessage.ToString();
        }

        public static string Decrypt(string cipherText, string key)
        {
            int keyLength = key.Length;
            int cipherTextLength = cipherText.Length;

            // Calcular el número de filas necesario en la matriz de descifrado
            int numRows = (int)Math.Ceiling((double)cipherTextLength / keyLength);

            // Crear una matriz para almacenar los caracteres del mensaje cifrado
            char[,] matrix = new char[numRows, keyLength];

            // Llenar la matriz con el mensaje cifrado
            int cipherIndex = 0;
            for (int col = 0; col < keyLength; col++)
            {
                int order = key.IndexOf(key[col]);
                for (int row = 0; row < numRows; row++)
                {
                    matrix[row, order] = cipherText[cipherIndex];
                    cipherIndex++;
                }
            }

            // Construir el mensaje descifrado
            StringBuilder decryptedMessage = new StringBuilder();
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < keyLength; col++)
                {
                    decryptedMessage.Append(matrix[row, col]);
                }
            }

            return decryptedMessage.ToString().Trim(); // Recortar los espacios finales si los hubiera
        }

        public static string Encrypt2(string message, string key)
        {
            try
            {
                int messageLength = message.Length;
                int keyLength = key.Length;

                // Calcula el número de filas necesario en la matriz de cifrado
                int numRows = (int)Math.Ceiling((double)messageLength / keyLength);

                // Crea una matriz para almacenar los caracteres del mensaje
                char[,] matrix = new char[numRows, keyLength];

                // Llena la matriz con el mensaje original
                int messageIndex = 0;
                for (int row = 0; row < numRows; row++)
                {
                    for (int col = 0; col < keyLength; col++)
                    {
                        if (messageIndex < messageLength)
                        {
                            matrix[row, col] = message[messageIndex];
                            messageIndex++;
                        }
                        else
                        {
                            matrix[row, col] = ' '; // Rellena con espacios si es necesario
                        }
                    }
                }

                // Construye el mensaje cifrado
                StringBuilder encryptedMessage = new StringBuilder();
                for (int col = 0; col < keyLength; col++)
                {
                    int order = int.Parse(key[col].ToString());
                    for (int row = 0; row < numRows; row++)
                    {
                        encryptedMessage.Append(matrix[row, order - 1]);
                    }
                }

                return encryptedMessage.ToString();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }


        public static string Decrypt2(string cipherText, string key)
        {
            try
            {
                int[] columnOrder = key.Select(c => int.Parse(c.ToString())).ToArray();
                int keyLength = columnOrder.Length;
                int cipherTextLength = cipherText.Length;

                int numRows = (int)Math.Ceiling((double)cipherTextLength / keyLength);
                char[,] matrix = new char[numRows, keyLength];
                int cipherIndex = 0;

                for (int col = 0; col < keyLength; col++)
                {
                    int order = columnOrder[col] - 1;

                    for (int row = 0; row < numRows; row++)
                    {
                        if (cipherIndex < cipherTextLength)
                        {
                            matrix[row, order] = cipherText[cipherIndex];
                            cipherIndex++;
                        }
                        else
                        {
                            matrix[row, order] = ' ';
                        }
                    }
                }

                StringBuilder decryptedMessage = new StringBuilder();

                for (int row = 0; row < numRows; row++)
                {
                    for (int col = 0; col < keyLength; col++)
                    {
                        char c = matrix[row, col];
                        if (c != ' ')
                        {
                            decryptedMessage.Append(c);
                        }
                    }
                }

                return decryptedMessage.ToString();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        


    }

}
