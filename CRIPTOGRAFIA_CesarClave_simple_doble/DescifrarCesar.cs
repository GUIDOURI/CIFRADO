using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRIPTOGRAFIA_CesarClave_simple_doble
{
    public partial class DescifrarCesar : Form
    {
        public DescifrarCesar()
        {
            InitializeComponent();
        }

        private void CifrarTexto()
        {
            try
            {
                string palabraClave = txtClave.Text;

                if (string.IsNullOrEmpty(palabraClave))
                {
                    MessageBox.Show("Ingrese una palabra clave.");
                    return;
                }

                string textoAEncriptar = string.Empty;

                // Verifica si hay texto en el TextBox txtTexto
                if (!string.IsNullOrEmpty(txtTexto.Text))
                {
                    textoAEncriptar = txtTexto.Text;
                }
                // Si no hay texto en el TextBox, verifica si se cargó un archivo
                else if (!string.IsNullOrEmpty(textoOriginal))
                {
                    textoAEncriptar = textoOriginal;
                }
                else
                {
                    MessageBox.Show("No hay texto cargado para cifrar. Utiliza el botón 'Cargar' para cargar un archivo o ingresa texto manualmente.");
                    return;
                }

                // Validar que textoAEncriptar solo contenga letras
                if (!Regex.IsMatch(textoAEncriptar, "^[a-zA-Z]+$"))
                {
                    MessageBox.Show("El texto a cifrar solo debe contener letras.");
                    return;
                }

                CesarCipher cifrador = new CesarCipher(palabraClave);
                string textoCifrado = cifrador.Cifrar(textoAEncriptar);
                txtTextoCifrado.Text = textoCifrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
          
            CifrarTexto();
        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                string palabraClave = txtClave.Text;

                if (string.IsNullOrEmpty(palabraClave))
                {
                    MessageBox.Show("Ingrese una palabra clave.");
                }
                else if (string.IsNullOrEmpty(txtTextoCifrado.Text))  // Utiliza txtTextoCifrado.Text para obtener el texto cifrado.
                {
                    MessageBox.Show("No hay texto cifrado para descifrar. Utiliza el botón 'Cargar Descifrados' para cargar un archivo o ingresa texto cifrado manualmente.");
                }
                else
                {
                    // Crea una instancia de la clase CesarCipher con la palabra clave.
                    CesarCipher cifrador = new CesarCipher(palabraClave);

                    // Obtiene el texto cifrado del TextBox txtTextoCifrado.
                    string textoCifrado = txtTextoCifrado.Text;

                    // Descifra el texto cifrado.
                    string textoDescifrado = cifrador.Descifrar(textoCifrado);

                    // Muestra el texto descifrado en el TextBox txtTextoDescifrado.
                    txtTextoDescifrado.Text = textoDescifrado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
            */

            try
            {
                string palabraClave = txtClave.Text;

                if (string.IsNullOrEmpty(palabraClave))
                {
                    MessageBox.Show("Ingrese una palabra clave.");
                }
                else if (string.IsNullOrEmpty(txtTextoCifrado.Text))
                {
                    MessageBox.Show("No hay texto cifrado para descifrar. Utiliza el botón 'Cargar Descifrados' para cargar un archivo o ingresa texto cifrado manualmente.");
                }
                else
                {
                    // Crea una instancia de la clase CesarCipher con la palabra clave.
                    CesarCipher cifrador = new CesarCipher(palabraClave);

                    // Obtiene el texto cifrado del TextBox txtTextoCifrado.
                    string textoCifrado = txtTextoCifrado.Text;

                    // Descifra el texto cifrado.
                    string textoDescifrado = cifrador.Descifrar(textoCifrado);

                    // Muestra el texto descifrado en el TextBox txtTextoDescifrado.
                    txtTextoDescifrado.Text = textoDescifrado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }

        }

        private string textoOriginal = string.Empty;
        private string textoCifrado = string.Empty;

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;

                    try
                    {
                        string fileContent = File.ReadAllText(selectedFile);

                        if (!string.IsNullOrEmpty(fileContent))
                        {
                            txtTexto.Text = fileContent;
                        }
                    }
                    catch (IOException ex)
                    {
                        // Manejo de errores en caso de problemas al abrir el archivo
                        MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCargarDescifrados_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto cifrado (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;

                    try
                    {
                        string fileContent = File.ReadAllText(selectedFile);

                        if (!string.IsNullOrEmpty(fileContent))
                        {
                            txtTextoCifrado.Text = fileContent;
                        }
                    }
                    catch (IOException ex)
                    {
                        // Manejo de errores en caso de problemas al abrir el archivo cifrado
                        MessageBox.Show("Error al cargar el archivo cifrado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia el campo de texto TXTTEXTO
            txtTexto.Text = string.Empty;

            // Limpia el campo de texto TXTCLAVE
            txtClave.Text = string.Empty;

            // Limpia el campo de texto TXTTEXTOCIFRADO
            txtTextoCifrado.Text = string.Empty;

            // Limpia el campo de texto TXTTXTODESCIFRADO
            txtTextoDescifrado.Text = string.Empty;
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtTexto.Clear();
            txtClave.Clear();
            txtTextoCifrado.Clear();
            txtTextoDescifrado.Clear();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string textoCifrado = txtTextoCifrado.Text;

            if (!string.IsNullOrEmpty(textoCifrado))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de texto cifrado (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = saveFileDialog.FileName;

                        try
                        {
                            File.WriteAllText(fileName, textoCifrado);
                            MessageBox.Show("El texto cifrado se ha guardado en el archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (IOException ex)
                        {
                            // Manejo de errores en caso de problemas al guardar el archivo cifrado
                            MessageBox.Show("Error al guardar el archivo cifrado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay texto cifrado para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
