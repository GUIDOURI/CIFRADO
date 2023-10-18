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
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(257, 465);
            panelMenu.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(0, 354);
            button3.Name = "button3";
            button3.Size = new Size(257, 84);
            button3.TabIndex = 6;
            button3.Text = "Cifrado Del Cesar por Palabra Clave";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(0, 247);
            button2.Name = "button2";
            button2.Size = new Size(257, 84);
            button2.TabIndex = 5;
            button2.Text = "Transposicion Doble";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 140);
            button1.Name = "button1";
            button1.Size = new Size(257, 84);
            button1.TabIndex = 4;
            button1.Text = "Transposicion Simple";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.DarkSlateGray;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(257, 0);
            panelContenedor.Margin = new Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(550, 465);
            panelContenedor.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 465);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
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