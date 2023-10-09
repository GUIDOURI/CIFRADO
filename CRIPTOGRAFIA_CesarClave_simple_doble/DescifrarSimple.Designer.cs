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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(44, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 116);
            label2.Name = "label2";
            label2.Size = new Size(240, 21);
            label2.TabIndex = 4;
            label2.Text = "RESULTADO DE DESCIFRADO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 23);
            textBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(187, 264);
            button3.Name = "button3";
            button3.Size = new Size(125, 33);
            button3.TabIndex = 7;
            button3.Text = "VOLVER";
            button3.UseVisualStyleBackColor = true;
            // 
            // DescifrarSimple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 338);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "DescifrarSimple";
            Text = "DescifrarSimple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button3;
    }
}