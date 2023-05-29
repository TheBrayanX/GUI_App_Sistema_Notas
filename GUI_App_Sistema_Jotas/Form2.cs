using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_App_Sistema_Jotas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Trae los textbox insertados y los convierte a double.
            double ciclo1_1 = Convert.ToDouble(txtnota1.Text);
            double ciclo1_2 = Convert.ToDouble(txtnota2.Text);
            double ciclo2_1 = Convert.ToDouble(txtnota3.Text);
            double ciclo2_2 = Convert.ToDouble(txtnota4.Text);
            double ciclo3_1 = Convert.ToDouble(txtnota5.Text);
            double ciclo3_2 = Convert.ToDouble(txtnota6.Text);

            //Se saca la sumatoria y se divide la nota.
            double nota_1 = ciclo1_1 + ciclo1_2;
            double contador = nota_1 / 2;

            double nota_2 = ciclo2_1 + ciclo2_2;
            double contador_2 = nota_2 / 2;

            double nota_3 = ciclo3_1 + ciclo3_2;
            double contador_3 = nota_3 / 2;

            //Promedio de las notas multiplicado por el porcentaje.
            double promedio = (contador * 0.15) + (contador_2 * 0.35) + (contador_3 * 0.50);

            //Condicional para saber si paso o no.
            if (promedio >= 3)
            {
                lblprom.Text = "Has sido aprobado con: " + promedio.ToString();
            }
            else
            {
                lblprom.Text = "Has sido reprobado con: " + promedio.ToString();
            }

            //Se llama la variable Label para que muestre el resultado y el ToString() termina de realizar la conversión o dará error.
            lb1message.Text = "Corte 1: su nota es " + contador.ToString();
            lbl2message.Text = "Corte 2: su nota es " + contador_2.ToString();
            lbl3message.Text = "Corte 3: su nota es " + contador_3.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Se llaman las variable de los label para que cuando se incialice, aparezca sin nombre y no como su predeterminado.
            lb1message.Text = "";
            txtnota1.Text = "";
            txtnota2.Text = "";

            lbl2message.Text = "";
            txtnota3.Text = "";
            txtnota4.Text = "";

            lbl3message.Text = "";
            txtnota5.Text = "";
            txtnota6.Text = "";

            lblprom.Text = "";

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            //Al presionar el boton cerrar, se cierra la pestaña.
            Close();
        }

        private void lb1message_Click(object sender, EventArgs e)
        {

        }
    }
}
