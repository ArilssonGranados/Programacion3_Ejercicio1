using System;
using System.Collections; //Agregué esta libreria para poder usar el ArrayList
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


        ArrayList datos = new ArrayList(); //Declaro el array con su variable para almacenar los datos que se solicitan
        private void button1_Click(object sender, EventArgs e)
        {
            //Inicio un if para mostrar error en caso de que no se ingrese el nombre
            if(textBox1.Text == "")
            {
                //También agregue la herramienta de errorProvider para mostrar el error en el textbox en blanco en caso de que no se haya llenado
                errorProvider1.SetError(textBox1, "Debe ingresar el nombre");
                textBox1.Focus();
                return;
            }
            //Inicio un if para mostrar error en caso de que no se ingrese la edad
            else if (textBox2.Text == "")
            {
                //También agregue la herramienta de errorProvider para mostrar el error en el textbox en blanco en caso de que no se haya llenado
                errorProvider1.SetError(textBox2, "Debe ingresar la edad");
                textBox2.Focus();
                return;
            }
            else
            {
                //Aquí dejo de mostrar los errores en caso de que las condiciones anteriores sean falsas.
                errorProvider1.SetError(textBox1, "");
                errorProvider1.SetError(textBox2, "");
            }

            //Aquí guardo los nombres y edades que el usuario ingrese
            datos.Add(textBox1.Text + " - " + textBox2.Text);

            //Aquí limpio los textbox para que el usuario ingrese más datos
            textBox2.Text = "";
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Aquí muestros los datos guardados en el arreglo y los muestro en el combobox
            for(int i = 0; i < datos.Count; i++)
            {
                comboBox1.Items.Add(datos[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        //Este botón es para cerrar el programa
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < datos.Count; i++)
            {
                datos.Sort();
                comboBox1.Items.Add(datos[i]);
            }
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < datos.Count; i++)
            {
                datos.Sort();
                datos.Reverse();
                comboBox1.Items.Add(datos[i]);
                
            }
        }
    }
}
