using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion3_Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ArrayList datos = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Debe ingresar el nombre");
                textBox1.Focus();
                return;
            }
            else if(textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Debe ingresar la edad");
                textBox2.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                errorProvider1.SetError(textBox2, "");
            }

            datos.Add(textBox1.Text + " - " + textBox2.Text);
            textBox2.Text = "";
            textBox1.Text = "";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            for(int i = 0; i < datos.Count; i++)
            {
                comboBox1.Items.Add(datos[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
