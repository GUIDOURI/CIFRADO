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
            // Aseguramos que la palabra clave esté en minúsculas.
            this.keyword = keyword.ToLower(); 
        }

        public string Cifrar(string mensaje)
        {
            StringBuilder cifrado = new StringBuilder();
            int keywordIndex = 0;

            foreach (char caracter in mensaje)
            {
                if (char.IsLetter(caracter))
                {
                    char inicio = char.IsUpper(caracter) ? 'A' : 'a';
                    char caracterClave = keyword[keywordIndex];

                    int desplazamiento = caracterClave - 'a';
                    char caracterCifrado = (char)(inicio + (caracter - inicio + desplazamiento) % 26);

                    cifrado.Append(caracterCifrado);

                    keywordIndex++;
                    if (keywordIndex == keyword.Length)
                    {
                        keywordIndex = 0;
                    }
                }
                else
                {
                    cifrado.Append(caracter);
                }
            }

            return cifrado.ToString();
        }

        public string Descifrar(string textoCifrado)
        {
            StringBuilder descifrado = new StringBuilder();
            int keywordIndex = 0;

            foreach (char caracter in textoCifrado)
            {
                if (char.IsLetter(caracter))
                {
                    char inicio = char.IsUpper(caracter) ? 'A' : 'a';
                    char caracterClave = keyword[keywordIndex];

                    int desplazamiento = caracterClave - 'a';
                    char caracterDescifrado = (char)(inicio + (caracter - inicio - desplazamiento + 26) % 26);

                    descifrado.Append(caracterDescifrado);

                    keywordIndex++;
                    if (keywordIndex == keyword.Length)
                    {
                        keywordIndex = 0;
                    }
                }
                else
                {
                    descifrado.Append(caracter);
                }
            }

            return descifrado.ToString();
        }
    }
}