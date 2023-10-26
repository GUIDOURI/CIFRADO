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
            string key = txtEncryptionKey.Text;
            string encryptedMessage = TranspositionCipher.Encrypt(message, key);
            txtEncrypted.Text = encryptedMessage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DescifrarSimple descifrarSimple = new DescifrarSimple();
            descifrarSimple.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtOriginal.Text;
                string key = txtEncryptionKey.Text;
                string encryptedMessage = TranspositionCipher.Encrypt2(message, key);
                txtEncrypted.Text = encryptedMessage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cifrar: " + ex.Message);
            }
        }
    }
}
