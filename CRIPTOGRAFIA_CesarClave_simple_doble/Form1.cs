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
            TransSimple formSecundario = new TransSimple();
            formSecundario.TopLevel = false;
            panelContenedor.Controls.Add(formSecundario);
            formSecundario.Dock = DockStyle.Fill;
            formSecundario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransDoble transDoble = new TransDoble();
            transDoble.Show();
        }
    }
}