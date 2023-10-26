namespace CRIPTOGRAFIA_CesarClave_simple_doble
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelContenedor = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 192, 192);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(225, 428);
            panelMenu.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(0, 266);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(225, 63);
            button3.TabIndex = 6;
            button3.Text = "Cifrado Del Cesar por Palabra Clave";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 185);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(225, 63);
            button2.TabIndex = 5;
            button2.Text = "Transposicion Doble";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 105);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(225, 63);
            button1.TabIndex = 4;
            button1.Text = "Transposicion Simple";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.DarkSlateGray;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(225, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(562, 428);
            panelContenedor.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 428);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panelContenedor;
    }
}