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
    public partial class TransDoble : Form
    {
        public TransDoble()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransposicionDoble transposicionDoble = new TransposicionDoble();

            if (string.IsNullOrEmpty(txt_Mensaje.Text))
            {
                MessageBox.Show("Por favor, ingrese el mensaje a Encriptar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }

            try
            {
                string mensajeCifrado = transposicionDoble.Cifrar(txt_Mensaje.Text.Replace(" ", ""));


                string mensajeCifradoDoble = transposicionDoble.Cifrar(mensajeCifrado);

                txt_MensajeCifrado.Text = mensajeCifradoDoble;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Encriptar el mensaje. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            TransposicionDoble transposicionDoble = new TransposicionDoble();

            if (string.IsNullOrEmpty(txt_Mensaje.Text))
            {
                MessageBox.Show("Por favor, ingrese o busque el mensaje a desencriptar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string mensajeDescifrado = transposicionDoble.Descifrar(txt_Mensaje.Text.Replace(" ", ""));


                string mensajeDescifradoDoble = transposicionDoble.Descifrar(mensajeDescifrado);

                txt_MensajeCifrado.Text = mensajeDescifradoDoble;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Desencriptar el mensaje. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string encryptedMessage = txt_MensajeCifrado.Text;

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
                        txt_Mensaje.Text = fileContent;
                    }
                }
            }
        }
    }
}
