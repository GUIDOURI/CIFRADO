using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRIPTOGRAFIA_CesarClave_simple_doble
{
    internal class GuardarAbrirTXT
    {
        public static bool GuardarComoTexto(string contenido, string nombreArchivo)
        {
            try
            {
                File.WriteAllText(nombreArchivo, contenido);
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
                if (File.Exists(nombreArchivo))
                {
                    return File.ReadAllText(nombreArchivo);
                }
                else
                {
                    Console.WriteLine("El archivo no existe.");
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir el archivo: " + ex.Message);
                return string.Empty;
            }
        }
    }
}
