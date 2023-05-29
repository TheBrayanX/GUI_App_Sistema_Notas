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
    public partial class lblresultado : Form
    {
        public lblresultado()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Se llaman las variable de los label para que cuando se incialice, aparezca sin nombre y no como su predeterminado.
            lbl_Resultado.Text = "";
            lbl_Promedio.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            //Se trae las variable de los insertado en los TextBox para poder convertirlos a entero.
            double corte_1 = Convert.ToDouble(txt1.Text);
            double corte_2 = Convert.ToDouble(txt2.Text);
            double corte_3 = Convert.ToDouble(txt3.Text);

            //Promedio de las 3 notas.
            double promedio = (corte_1 * 0.15) + (corte_2 * 0.35) + (corte_3 * 0.50);

            //Condicional para saber si pasa la materia o no.
            if (promedio >= 3)
            {
                lbl_Promedio.Text = "Has sido aprobado ";
            } else
            {
                lbl_Promedio.Text = "Has sido reprobado ";  
            }

            //Se llama la variable Label para que muestre el resultado y el ToString() termina de realizar la conversión o dará error.
            lbl_Resultado.Text = "Su nota final es: " + promedio.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cuando se presiona el boton cerrar, se cierra la pestaña.
            Close();
        }
    }
}
