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
                    string fileContent = GuardarAbrirTXT.AbrirComoTexto(selectedFile);

                    if (!string.IsNullOrEmpty(fileContent))
                    {
                        txtCipherText.Text = fileContent;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string cipherText = txtCipherText.Text;
            string decryptionKey = txtDecryptionKey.Text;

            // Validar que la clave de descifrado solo contenga números
            if (!string.IsNullOrWhiteSpace(decryptionKey) && decryptionKey.All(char.IsDigit))
            {
                if (string.IsNullOrWhiteSpace(cipherText))
                {
                    MessageBox.Show("Ingresa un mensaje cifrado válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string decryptedMessage = TranspositionCipher.Decrypt2(cipherText, decryptionKey);

                if (decryptedMessage.StartsWith("Error:"))
                {
                    MessageBox.Show("Ocurrió un error durante el descifrado. Asegúrate de usar la clave correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtDecrypted.Text = decryptedMessage.Replace(" ", ""); // Elimina los espacios
                }
            }
            else
            {
                MessageBox.Show("La clave de descifrado debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



    }
}
