using EncuestasLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuentasForm
{
    public partial class Form1 : Form
    {
        ProcesoEncuestas proceso = new ProcesoEncuestas();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FormRegistroDeEncuesta formRegistro = new FormRegistroDeEncuesta();
            if (formRegistro.ShowDialog() == DialogResult.OK)
            {
               


                Encuesta nuevo = new Encuesta();

                Console.WriteLine("Modo de transporte habitual");

                nuevo.UsaBicicleta = formRegistro.cbUsaBicicleta.Checked; //("¿Usa bicleta?: S/N");

                nuevo.UsaAuto = formRegistro.cbUsaAuto.Checked;//("¿Usa Automóvil?: S/N");
                nuevo.UsaTransportePublico = formRegistro.cbUsaCole.Checked; //("¿Usa Transporte público?: S/N");

                //Console.WriteLine("¿Cuál es la distancia aproximada a su destino de trabajo/estudio en km? (ej:1,5)\n");
                nuevo.DistanciaASuDestino = Convert.ToDouble(formRegistro.tbIngresoDistancia.Text); //Convert.ToDouble(Console.ReadLine());

                bool puedeSerContactado = formRegistro.cbContacto.Checked; //("¿Puede ser contactado?: S/N");
                if (puedeSerContactado == true)
                {
                    //Console.Write("Email: ");
                    nuevo.Email = formRegistro.tbContacto.Text;//Console.ReadLine();
                                                       //Console.Write("\n");
                }

                proceso.RegistrarEncuesta(nuevo, puedeSerContactado);

                //Console.WriteLine("\nEncuesta procesada!");

                //Console.WriteLine("Presione una tecla para volver al menú principal");
                //Console.ReadKey();
                MessageBox.Show("Encuesta procesada!");
            }
        }

        private void btImprimirResultados_Click(object sender, EventArgs e)
        {
            FormInforme formInforme = new FormInforme();
            formInforme.listBox1.Items.Add($"\t{"Bicicleta:",-20}  {proceso.PorcBicleta,10:f2}%");
            formInforme.listBox1.Items.Add($"\t{"Automóvil:",-20}  {proceso.PorcAuto,10:f2}%");
            formInforme.listBox1.Items.Add($"\t{"Transporte público:",-20}  {proceso.PorcTranspPublico,10:f2}%");
            formInforme.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
