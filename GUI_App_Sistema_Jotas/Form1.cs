namespace GUI_App_Sistema_Jotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se crea un objeto para poder llamar a la pestaña.
            Form2 form2= new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Se crea un objeto para poder llamar a la pestaña.
            lblresultado form3 = new lblresultado();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Cuando se presione el boton de cerrar, se cerrará la pestaña.
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}