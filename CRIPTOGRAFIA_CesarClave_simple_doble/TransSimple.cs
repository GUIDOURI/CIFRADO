using Criptografia;
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
    public partial class TransSimple : Form
    {
        public TransSimple()
        {
            InitializeComponent();
        }

        private void TransSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string encryptedMessage = txtEncrypted.Text;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = "mensaje_cifrado.txt"; // Nombre predeterminado

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (GuardarAbrirTXT.GuardarComoTexto(encryptedMessage, filePath))
                    {
                        MessageBox.Show("El cifrado se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el cifrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            string message = txtOriginal.Text;
            string encryptionKey = txtEncryptionClave.Text;

            // Validar que el mensaje solo contenga letras
            if (!string.IsNullOrWhiteSpace(message) && message.All(char.IsLetter))
            {
                if (string.IsNullOrWhiteSpace(encryptionKey))
                {
                    MessageBox.Show("Ingresa una clave de cifrado válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string encryptedMessage = TranspositionCipher.Encrypt2(message, encryptionKey);

                if (encryptedMessage.StartsWith("Error:"))
                {
                    MessageBox.Show("Ocurrió un error durante el cifrado. Asegúrate de usar la clave correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtEncrypted.Text = encryptedMessage;
                }
            }
            else
            {
                MessageBox.Show("El mensaje a cifrar debe contener solo letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DescifrarSimple descifrarSimple = new DescifrarSimple();
            descifrarSimple.Location = this.Location;
            descifrarSimple.Size = this.Size;
            descifrarSimple.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtOriginal.Text;
                string key = txtEncryptionClave.Text;

                if (string.IsNullOrWhiteSpace(message) || string.IsNullOrWhiteSpace(key))
                {
                    MessageBox.Show("Ingresa un mensaje y una clave válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsNumeric(key))
                {
                    MessageBox.Show("La clave debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string encryptedMessage = TranspositionCipher.Encrypt2(message, key);
                txtEncrypted.Text = encryptedMessage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cifrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private void button4_Click(object sender, EventArgs e)
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
                        txtOriginal.Text = fileContent;
                    }
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtOriginal.Text;
            string decryptionKey = txtEncrypted.Text;

            if (string.IsNullOrEmpty(cipherText) || string.IsNullOrEmpty(decryptionKey))
            {
                MessageBox.Show("Por favor, ingrese el mensaje cifrado y la clave de descifrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string decryptedMessage = TranspositionCipher.Decrypt(cipherText, decryptionKey);
                txtEncrypted.Text = decryptedMessage;
                MessageBox.Show("El mensaje se descifró correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo descifrar el mensaje. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cipherText = txtOriginal.Text;
            string decryptionKey = txtEncryptionClave.Text;

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
                    txtEncrypted.Text = decryptedMessage.Replace(" ", ""); // Elimina los espacios
                }
            }
            else
            {
                MessageBox.Show("La clave de descifrado debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEncryptionKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TransposicionDoble transposicionDoble = new TransposicionDoble();

            if (string.IsNullOrEmpty(txtOriginal.Text))
            {
                MessageBox.Show("Por favor, ingrese el mensaje a Encriptar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }

            try
            {
                string mensajeCifrado = transposicionDoble.Cifrar(txtOriginal.Text.Replace(" ", ""));

                txtEncrypted.Text = mensajeCifrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Encriptar el mensaje. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
