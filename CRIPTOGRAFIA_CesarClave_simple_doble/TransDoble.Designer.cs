namespace CRIPTOGRAFIA_CesarClave_simple_doble
{
    partial class TransDoble
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txt_Mensaje = new TextBox();
            txt_MensajeCifrado = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(153, 162);
            button1.Name = "button1";
            button1.Size = new Size(91, 40);
            button1.TabIndex = 0;
            button1.Text = "Encriptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(294, 162);
            button2.Name = "button2";
            button2.Size = new Size(91, 40);
            button2.TabIndex = 1;
            button2.Text = "Descencriptar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(153, 311);
            button3.Name = "button3";
            button3.Size = new Size(91, 40);
            button3.TabIndex = 2;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(294, 311);
            button4.Name = "button4";
            button4.Size = new Size(91, 40);
            button4.TabIndex = 3;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txt_Mensaje
            // 
            txt_Mensaje.Location = new Point(133, 122);
            txt_Mensaje.Name = "txt_Mensaje";
            txt_Mensaje.Size = new Size(252, 23);
            txt_Mensaje.TabIndex = 4;
            // 
            // txt_MensajeCifrado
            // 
            txt_MensajeCifrado.Location = new Point(133, 265);
            txt_MensajeCifrado.Name = "txt_MensajeCifrado";
            txt_MensajeCifrado.Size = new Size(252, 23);
            txt_MensajeCifrado.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 80);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 6;
            label1.Text = "MENSAJE A CIFRAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(17, 43, 14);
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(440, 42);
            label2.TabIndex = 7;
            label2.Text = "TRANSPOSICION DOBLE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 227);
            label3.Name = "label3";
            label3.Size = new Size(209, 21);
            label3.TabIndex = 8;
            label3.Text = "RESULTADO DE CIFRADO";
            // 
            // TransDoble
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(630, 374);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_MensajeCifrado);
            Controls.Add(txt_Mensaje);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransDoble";
            Text = "TransDoble";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txt_Mensaje;
        private TextBox txt_MensajeCifrado;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}