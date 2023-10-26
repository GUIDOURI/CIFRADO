namespace CRIPTOGRAFIA_CesarClave_simple_doble
{
    partial class DescifrarCesar
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
            txtTexto = new TextBox();
            txtTextoCifrado = new TextBox();
            txtTextoDescifrado = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtClave = new TextBox();
            label5 = new Label();
            btnCifrar = new Button();
            btnDescifrar = new Button();
            btnLimpiar = new Button();
            btnExportar = new Button();
            btnCargar = new Button();
            btnCargarDescifrados = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(17, 43, 14);
            label1.Location = new Point(29, 39);
            label1.Name = "label1";
            label1.Size = new Size(512, 42);
            label1.TabIndex = 4;
            label1.Text = "CIFRADO CESAR POR CLAVE";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(64, 150);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(283, 23);
            txtTexto.TabIndex = 5;
            // 
            // txtTextoCifrado
            // 
            txtTextoCifrado.Location = new Point(64, 266);
            txtTextoCifrado.Name = "txtTextoCifrado";
            txtTextoCifrado.Size = new Size(283, 23);
            txtTextoCifrado.TabIndex = 6;
            // 
            // txtTextoDescifrado
            // 
            txtTextoDescifrado.Location = new Point(64, 333);
            txtTextoDescifrado.Name = "txtTextoDescifrado";
            txtTextoDescifrado.Size = new Size(283, 23);
            txtTextoDescifrado.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 242);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 8;
            label2.Text = "TEXTO CIFRADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(64, 126);
            label3.Name = "label3";
            label3.Size = new Size(157, 21);
            label3.TabIndex = 9;
            label3.Text = "INGRESE EL TEXTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(64, 309);
            label4.Name = "label4";
            label4.Size = new Size(168, 21);
            label4.TabIndex = 10;
            label4.Text = "TEXTO DESCIFRADO";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(143, 199);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(204, 23);
            txtClave.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(64, 201);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 12;
            label5.Text = "CLAVE";
            // 
            // btnCifrar
            // 
            btnCifrar.Location = new Point(441, 138);
            btnCifrar.Name = "btnCifrar";
            btnCifrar.Size = new Size(75, 23);
            btnCifrar.TabIndex = 13;
            btnCifrar.Text = "CIFRAR";
            btnCifrar.UseVisualStyleBackColor = true;
            btnCifrar.Click += btnCifrar_Click;
            // 
            // btnDescifrar
            // 
            btnDescifrar.Location = new Point(441, 199);
            btnDescifrar.Name = "btnDescifrar";
            btnDescifrar.Size = new Size(75, 23);
            btnDescifrar.TabIndex = 14;
            btnDescifrar.Text = "DESCIFRAR";
            btnDescifrar.UseVisualStyleBackColor = true;
            btnDescifrar.Click += btnDescifrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(441, 264);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(441, 332);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 16;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.White;
            btnCargar.Location = new Point(353, 148);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(66, 25);
            btnCargar.TabIndex = 18;
            btnCargar.Text = "CARGAR";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnCargarDescifrados
            // 
            btnCargarDescifrados.BackColor = Color.White;
            btnCargarDescifrados.Location = new Point(353, 264);
            btnCargarDescifrados.Name = "btnCargarDescifrados";
            btnCargarDescifrados.Size = new Size(66, 25);
            btnCargarDescifrados.TabIndex = 19;
            btnCargarDescifrados.Text = "CARGAR";
            btnCargarDescifrados.UseVisualStyleBackColor = false;
            btnCargarDescifrados.Click += btnCargarDescifrados_Click;
            // 
            // DescifrarCesar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(562, 428);
            Controls.Add(btnCargarDescifrados);
            Controls.Add(btnCargar);
            Controls.Add(btnExportar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDescifrar);
            Controls.Add(btnCifrar);
            Controls.Add(label5);
            Controls.Add(txtClave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTextoDescifrado);
            Controls.Add(txtTextoCifrado);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DescifrarCesar";
            Text = ". ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTexto;
        private TextBox txtTextoCifrado;
        private TextBox txtTextoDescifrado;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtClave;
        private Label label5;
        private Button btnCifrar;
        private Button btnDescifrar;
        private Button btnLimpiar;
        private Button btnExportar;
        private Button btnCargar;
        private Button btnCargarDescifrados;
    }
}