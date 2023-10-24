using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRIPTOGRAFIA_CesarClave_simple_doble
{
    public class GuardarAbrirTXT
    {
        public static bool GuardarComoTexto(string contenido, string nombreArchivo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(contenido))
                {
                    Console.WriteLine("El contenido está vacío. No se puede guardar el archivo.");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(nombreArchivo))
                {
                    Console.WriteLine("Nombre de archivo no válido. No se puede guardar el archivo.");
                    return false;
                }

                File.WriteAllText(nombreArchivo, contenido);
                Console.WriteLine("El archivo se guardó exitosamente.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el archivo: " + ex.Message);
                return false;
            }
        }

        public static string AbrirComoTexto(string nombreArchivo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombreArchivo))
                {
                    Console.WriteLine("Nombre de archivo no válido. No se puede abrir el archivo.");
                    return string.Empty;
                }

                if (!File.Exists(nombreArchivo))
                {
                    Console.WriteLine("El archivo no existe.");
                    return string.Empty;
                }

                string fileContent = File.ReadAllText(nombreArchivo);
                Console.WriteLine("El archivo se abrió exitosamente.");
                return fileContent;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir el archivo: " + ex.Message);
                return string.Empty;
            }
        }
    }
}
