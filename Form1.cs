namespace Gestion_Escolar
{
    public partial class Form1 : Form
    {
        string Usuario = "admin";
        string Contrase�a = "admin123";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

            if (txtUsername.Text == Usuario && txtPassword.Text == Contrase�a)
            {
                MessageBox.Show($"�Bienvenido {Usuario}!");
                // Aqu� puedes mostrar el formulario principal para el usuario autenticado.

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}