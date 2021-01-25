using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        static Operaciones op = new Operaciones();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxOperaciones.Text == "Suma")
            {
                lblres.Text = (op.Suma(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }

            else if (cbxOperaciones.Text == "Resta")
            {
                lblres.Text = (op.Resta(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }


            else if (cbxOperaciones.Text == "Multiplicacion")
            {
                lblres.Text = (op.Mult(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }


            else if (cbxOperaciones.Text == "Division")
            {
                lblres.Text = (op.Div(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }


        }
    }
}
