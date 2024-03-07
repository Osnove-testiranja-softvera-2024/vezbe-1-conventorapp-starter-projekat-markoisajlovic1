using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Pounds";
            label2.Text = "Kg";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Feet";
            label2.Text = "Meters";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                float weight = float.Parse(textBox1.Text);
                convertToKg(weight);
            }

            if (radioButton2.Checked)
            {
                float height = float.Parse(textBox2.Text);
                convertToM(height);
            }

        }


        //zadatak
        public void convertToKg(float weight)
        {
            double kg = weight * 0.4;
            textBox2.Text = kg.ToString();
        }

        public void convertToM(float height)
        {
            double m = height * 0.3;
            textBox2.Text = m.ToString();
        }


    }
}
