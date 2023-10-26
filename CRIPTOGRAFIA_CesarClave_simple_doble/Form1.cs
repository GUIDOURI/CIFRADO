namespace CRIPTOGRAFIA_CesarClave_simple_doble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TransSimple transSimple = new TransSimple();
            //transSimple.Show();
            panelContenedor.Controls.Clear();
            TransSimple formSecundario = new TransSimple();
            formSecundario.TopLevel = false;
            panelContenedor.Controls.Add(formSecundario);
            formSecundario.Dock = DockStyle.Fill;
            formSecundario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            TransDoble transDoble = new TransDoble();
            transDoble.TopLevel = false;
            panelContenedor.Controls.Add((transDoble));
            transDoble.Dock = DockStyle.Fill;
            transDoble.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            DescifrarCesar descifrarCesar = new DescifrarCesar();
            descifrarCesar.TopLevel = false;
            panelContenedor.Controls.Add((descifrarCesar));
            descifrarCesar.Dock = DockStyle.Fill;
            descifrarCesar.Show();
        }
    }
}