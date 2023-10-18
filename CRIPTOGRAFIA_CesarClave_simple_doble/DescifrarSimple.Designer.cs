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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(214, 28);
            label1.TabIndex = 2;
            label1.Text = "DESCIFRAR CIFRADO";
            // 
            // txtCipherText
            // 
            txtCipherText.Location = new Point(50, 75);
            txtCipherText.Margin = new Padding(3, 4, 3, 4);
            txtCipherText.Name = "txtCipherText";
            txtCipherText.Size = new Size(443, 27);
            txtCipherText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(89, 124);
            label2.Name = "label2";
            label2.Size = new Size(293, 28);
            label2.TabIndex = 4;
            label2.Text = "RESULTADO DE DESCIFRADO";
            // 
            // txtDecrypted
            // 
            txtDecrypted.Location = new Point(167, 169);
            txtDecrypted.Margin = new Padding(3, 4, 3, 4);
            txtDecrypted.Name = "txtDecrypted";
            txtDecrypted.Size = new Size(366, 27);
            txtDecrypted.TabIndex = 5;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(214, 352);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(143, 44);
            button3.TabIndex = 7;
            button3.Text = "VOLVER";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(390, 352);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(143, 44);
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
            label3.Location = new Point(35, 237);
            label3.Name = "label3";
            label3.Size = new Size(168, 28);
            label3.TabIndex = 11;
            label3.Text = "PALABRA CLAVE";
            // 
            // txtDecryptionKey
            // 
            txtDecryptionKey.Location = new Point(50, 284);
            txtDecryptionKey.Margin = new Padding(3, 4, 3, 4);
            txtDecryptionKey.Name = "txtDecryptionKey";
            txtDecryptionKey.Size = new Size(250, 27);
            txtDecryptionKey.TabIndex = 12;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecrypt.Location = new Point(362, 254);
            btnDecrypt.Margin = new Padding(3, 4, 3, 4);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(159, 57);
            btnDecrypt.TabIndex = 13;
            btnDecrypt.Text = "DESCIFRAR";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // DescifrarSimple
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 451);
            Controls.Add(btnDecrypt);
            Controls.Add(txtDecryptionKey);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(txtDecrypted);
            Controls.Add(label2);
            Controls.Add(txtCipherText);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}