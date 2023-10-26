namespace CRIPTOGRAFIA_CesarClave_simple_doble
{
    partial class DescifrarSimple
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
            label1 = new Label();
            txtCipherText = new TextBox();
            label2 = new Label();
            txtDecrypted = new TextBox();
            button3 = new Button();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label3 = new Label();
            txtDecryptionKey = new TextBox();
            btnDecrypt = new Button();
            button2 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(176, 21);
            label1.TabIndex = 2;
            label1.Text = "DESCIFRAR CIFRADO";
            // 
            // txtCipherText
            // 
            txtCipherText.Location = new Point(44, 56);
            txtCipherText.Name = "txtCipherText";
            txtCipherText.Size = new Size(388, 23);
            txtCipherText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 93);
            label2.Name = "label2";
            label2.Size = new Size(240, 21);
            label2.TabIndex = 4;
            label2.Text = "RESULTADO DE DESCIFRADO";
            // 
            // txtDecrypted
            // 
            txtDecrypted.Location = new Point(146, 127);
            txtDecrypted.Name = "txtDecrypted";
            txtDecrypted.Size = new Size(321, 23);
            txtDecrypted.TabIndex = 5;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(138, 264);
            button3.Name = "button3";
            button3.Size = new Size(125, 33);
            button3.TabIndex = 7;
            button3.Text = "VOLVER";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(299, 264);
            button1.Name = "button1";
            button1.Size = new Size(125, 33);
            button1.TabIndex = 8;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 178);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 11;
            label3.Text = "PALABRA CLAVE";
            // 
            // txtDecryptionKey
            // 
            txtDecryptionKey.Location = new Point(44, 213);
            txtDecryptionKey.Name = "txtDecryptionKey";
            txtDecryptionKey.Size = new Size(219, 23);
            txtDecryptionKey.TabIndex = 12;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecrypt.Location = new Point(273, 178);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(115, 32);
            btnDecrypt.TabIndex = 13;
            btnDecrypt.Text = "DESCIFRAR";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(394, 178);
            button2.Name = "button2";
            button2.Size = new Size(123, 32);
            button2.TabIndex = 14;
            button2.Text = "DESCIFRAR 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(331, 216);
            button4.Name = "button4";
            button4.Size = new Size(122, 32);
            button4.TabIndex = 15;
            button4.Text = "DESCIFRAR 3";
            button4.UseVisualStyleBackColor = true;
            // 
            // DescifrarSimple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 389);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(btnDecrypt);
            Controls.Add(txtDecryptionKey);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(txtDecrypted);
            Controls.Add(label2);
            Controls.Add(txtCipherText);
            Controls.Add(label1);
            Name = "DescifrarSimple";
            Text = "DescifrarSimple";
            Load += DescifrarSimple_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCipherText;
        private Label label2;
        private TextBox txtDecrypted;
        private Button button3;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label3;
        private TextBox txtDecryptionKey;
        private Button btnDecrypt;
        private Button button2;
        private Button button4;
    }
}