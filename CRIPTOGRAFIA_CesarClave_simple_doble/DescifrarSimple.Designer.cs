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
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
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
            // textBox1
            // 
            textBox1.Location = new Point(50, 93);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(82, 155);
            label2.Name = "label2";
            label2.Size = new Size(293, 28);
            label2.TabIndex = 4;
            label2.Text = "RESULTADO DE DESCIFRADO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 219);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(366, 27);
            textBox2.TabIndex = 5;
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
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // DescifrarSimple
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 451);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
        private OpenFileDialog openFileDialog1;
    }
}