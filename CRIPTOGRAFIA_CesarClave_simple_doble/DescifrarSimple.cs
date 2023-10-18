using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRIPTOGRAFIA_CesarClave_simple_doble
{
    public partial class DescifrarSimple : Form
    {
        public DescifrarSimple()
        {
            InitializeComponent();
        }

        private void DescifrarSimple_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;

                    // Lee el contenido del archivo seleccionado y colócalo en el TextBox de mensaje cifrado
                    try
                    {
                        string fileContent = File.ReadAllText(selectedFile);
                        txtCipherText.Text = fileContent;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtCipherText.Text;
            string decryptionKey = txtDecryptionKey.Text;

            if (string.IsNullOrEmpty(cipherText) || string.IsNullOrEmpty(decryptionKey))
            {
                MessageBox.Show("Por favor, ingrese el mensaje cifrado y la clave de descifrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string decryptedMessage = TranspositionCipher.Decrypt(cipherText, decryptionKey);
                txtDecrypted.Text = decryptedMessage;
                MessageBox.Show("El mensaje se descifró correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo descifrar el mensaje. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
