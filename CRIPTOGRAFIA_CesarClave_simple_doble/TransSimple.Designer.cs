namespace CRIPTOGRAFIA_CesarClave_simple_doble
{
    partial class TransSimple
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
            btnEncrypt = new Button();
            label1 = new Label();
            txtOriginal = new TextBox();
            label2 = new Label();
            txtEncrypted = new TextBox();
            button2 = new Button();
            button3 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            label3 = new Label();
            txtEncryptionKey = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEncrypt.Location = new Point(318, 202);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(166, 41);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.Text = "CIFRAR";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 1;
            label1.Text = "PALABRA PARA CIFRAR";
            // 
            // txtOriginal
            // 
            txtOriginal.Location = new Point(12, 56);
            txtOriginal.Name = "txtOriginal";
            txtOriginal.Size = new Size(388, 23);
            txtOriginal.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 99);
            label2.Name = "label2";
            label2.Size = new Size(209, 21);
            label2.TabIndex = 3;
            label2.Text = "RESULTADO DE CIFRADO";
            // 
            // txtEncrypted
            // 
            txtEncrypted.Location = new Point(73, 139);
            txtEncrypted.Name = "txtEncrypted";
            txtEncrypted.Size = new Size(388, 23);
            txtEncrypted.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(309, 293);
            button2.Name = "button2";
            button2.Size = new Size(125, 33);
            button2.TabIndex = 5;
            button2.Text = "DESCIFRAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(178, 293);
            button3.Name = "button3";
            button3.Size = new Size(125, 33);
            button3.TabIndex = 6;
            button3.Text = "VOLVER";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 182);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 10;
            label3.Text = "PALABRA CLAVE";
            // 
            // txtEncryptionKey
            // 
            txtEncryptionKey.Location = new Point(37, 224);
            txtEncryptionKey.Name = "txtEncryptionKey";
            txtEncryptionKey.Size = new Size(204, 23);
            txtEncryptionKey.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(48, 293);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 33);
            btnSave.TabIndex = 12;
            btnSave.Text = "GUARDAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // TransSimple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 338);
            Controls.Add(btnSave);
            Controls.Add(txtEncryptionKey);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtEncrypted);
            Controls.Add(label2);
            Controls.Add(txtOriginal);
            Controls.Add(label1);
            Controls.Add(btnEncrypt);
            Name = "TransSimple";
            Text = "TransSimple";
            Load += TransSimple_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncrypt;
        private Label label1;
        private TextBox txtOriginal;
        private Label label2;
        private TextBox txtEncrypted;
        private Button button2;
        private Button button3;
        private SaveFileDialog saveFileDialog1;
        private Label label3;
        private TextBox txtEncryptionKey;
        private Button btnSave;
    }
}