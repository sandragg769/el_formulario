using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ElFormulario
{
    public partial class fmElFormulario : Form
    {
        public fmElFormulario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btVisible.Text = "Pon no Visible";
            btVisible.ForeColor = Color.Green;
        }

        private void fmElFormulario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        // Botón ARRIBA
        private void btArriba_Click(object sender, EventArgs e)
        {
            // Si se sale por arriba
            if (laMover.Top <= -laMover.Height)
            {
                laMover.Top = this.ClientSize.Height; // aparece por abajo
            }
            else
            {
                laMover.Top = laMover.Top - 2; // sube 2 píxeles
            }
        }

        // Botón ABAJO
        private void btAbajo_Click(object sender, EventArgs e)
        {
            // Si se sale por abajo
            if (laMover.Top >= this.ClientSize.Height)
            {
                laMover.Top = -laMover.Height; // aparece por arriba
            }
            else
            {
                laMover.Top = laMover.Top + 2; // baja 2 píxeles
            }
        }

        // Botón DERECHA
        private void btDerecha_Click(object sender, EventArgs e)
        {
            // Si se sale por la derecha
            if (laMover.Left >= this.ClientSize.Width)
            {
                laMover.Left = -laMover.Width; // aparece por la izquierda
            }
            else
            {
                laMover.Left = laMover.Left + 2; // avanza a la derecha
            }
        }

        // Botón IZQUIERDA
        private void btIzquierda_Click(object sender, EventArgs e)
        {
            // Si se sale por la izquierda
            if (laMover.Left <= -laMover.Width)
            {
                laMover.Left = this.ClientSize.Width; // aparece por la derecha
            }
            else
            {
                laMover.Left = laMover.Left - 2; // avanza a la izquierda
            }
        }

        private void btVisible_Click(object sender, EventArgs e)
        {
            pnBotones.Visible = !pnBotones.Visible;
            if (pnBotones.Visible)
            {
                btVisible.Text = "Pon No Visible";
                btVisible.ForeColor = Color.Green;
            }
            else
            {
                btVisible.Text = "Pon Visible";
                btVisible.ForeColor = Color.Red;
            }
        }

        private void fmElFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Adiós");
        }

        private void btAumenta_Click(object sender, EventArgs e)
        {
            float fAumenta = laMover.Font.Size; // Variable para asignar nuevo tamaño
                   fAumenta++;
            if (fAumenta <= 100) // Tamaño máximo permitido 
            {
               laTamanyo.Text = Convert.ToString(fAumenta);//Asignamos valor al  label que indica el tamaño(parte central inferior izquierda) 
               btAumenta.Text = "Suma: " + Convert.ToString(fAumenta);//Asignamos también nuevo valor a los text
               btDisminuye.Text = "Resta: " + Convert.ToString(fAumenta);//de los botones que realizan acción al hacer click
               laMover.Font = new Font("", fAumenta, FontStyle.Regular,GraphicsUnit.Point);//Código que asigna nuevo tamaño a la fuente del label. 
            }
        }

        private void btDisminuye_Click(object sender, EventArgs e)
        {
            float fDisminuye = laMover.Font.Size; // Obtener el tamaño actual de la fuente
            fDisminuye--; // Reducir 1 punto

            if (fDisminuye >= 8) // Tamaño mínimo permitido (puedes ajustar el valor)
            {
                laTamanyo.Text = Convert.ToString(fDisminuye); // Mostrar tamaño actual
                btAumenta.Text = "Suma: " + Convert.ToString(fDisminuye);
                btDisminuye.Text = "Resta: " + Convert.ToString(fDisminuye);

                // Cambiar el tamaño de la fuente del Label laMover
                laMover.Font = new Font("", fDisminuye, FontStyle.Regular, GraphicsUnit.Point);
            }
        }




    }
}
