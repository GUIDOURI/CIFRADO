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
            TransSimple transSimple = new TransSimple();
            transSimple.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransDoble transDoble = new TransDoble();
            transDoble.Show();
        }
    }
}