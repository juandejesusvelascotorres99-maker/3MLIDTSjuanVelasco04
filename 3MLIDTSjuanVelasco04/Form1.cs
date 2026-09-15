using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MLIDTSjuanVelasco04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
              

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = textBox1.Text;
            string apellidos = textBox2.Text;
            string telefono = textBox3.Text;
            string edad = textBox4.Text;
            string estatura = textBox5.Text;
            string genero = "";

            if (radioButton1.Checked)
            {
                genero = "Masculino";
            }
            else if (radioButton2.Checked)
            {
                genero = "Femenino";
            }
            else if (radioButton3.Checked)
            {
                genero = "Otro";
            }

            string mensaje = $"Nombres: {nombres}\nApellidos: {apellidos}\n" +
                $"Genero: {genero}\nEdad: {edad}\nTelefono: {telefono}\nEstatura: {estatura}\n\r";

            //Ruta del almacenamiento de archivo TXT
            string rutaFile = "C:\\Users\\juand\\source\\repos\\3MLIDTS-JUANvelasco04\\3MLIDTS-JUANvelasco04\\3MLIDTSjuanvelasco04.txt";

            //Valor de verificación de archivo existente
            bool ArchivoExiste = File.Exists(rutaFile);

            /// Instanciacion de la Clase/objeto StreamWriter para escribir archivo TXT
            using (StreamWriter Escritor = new StreamWriter(rutaFile, true))
            {
                if (ArchivoExiste)
                {
                    Escritor.WriteLine();
                }
                Escritor.WriteLine(mensaje);
            }

            MessageBox.Show(mensaje, "Registros de Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


        }
        }
    }
    

