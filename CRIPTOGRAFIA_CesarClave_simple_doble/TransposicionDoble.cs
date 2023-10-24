using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia
{
    public class TransposicionDoble
    {

        public string Cifrar(string mensaje)
        {
            // Convertir el mensaje en una matriz unidimensional
            char[] array = mensaje.ToCharArray();

            // Crear dos listas para almacenar las letras en posiciones pares e impares
            List<char> pares = new List<char>();
            List<char> impares = new List<char>();

            // Recorrer la matriz y agregar las letras a las listas correspondientes
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) // Posiciones pares
                {
                    pares.Add(array[i]);
                }
                else // Posiciones impares
                {
                    impares.Add(array[i]);
                }
            }

            // Combinar las listas para obtener el mensaje cifrado
            List<char> cifrado = new List<char>();
            cifrado.AddRange(pares);
            cifrado.AddRange(impares);

            // Convertir la lista cifrada en una cadena para obtener el mensaje cifrado
            string mensajeCifrado = new string(cifrado.ToArray());

            return mensajeCifrado;
        }

        public string Descifrar(string mensajeCifrado)
        {
            // Calcular el punto medio
            int medio = (mensajeCifrado.Length / 2) + 1;

            // Dividir el mensaje cifrado en dos partes
            string primeraParte = mensajeCifrado.Substring(0, medio);
            string segundaParte = mensajeCifrado.Substring(medio);

            // Convertir las partes en matrices unidimensionales
            char[] array1 = primeraParte.ToCharArray();
            char[] array2 = segundaParte.ToCharArray();

            // Crear una lista para almacenar el mensaje descifrado
            List<char> descifrado = new List<char>();

            // Recorrer las matrices y agregar las letras a la lista descifrada
            for (int i = 0; i < array1.Length; i++)
            {
                descifrado.Add(array1[i]);
                if (i < array2.Length)
                {
                    descifrado.Add(array2[i]);
                }
            }

            // Convertir la lista descifrada en una cadena para obtener el mensaje descifrado
            string mensajeDescifrado = new string(descifrado.ToArray());

            return mensajeDescifrado;
        }

    }


 }
