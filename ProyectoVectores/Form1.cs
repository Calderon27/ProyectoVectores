using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVectores
{
    public partial class Form1 : Form
    {
        List<string> listaVectores = new List<string>();
        const int MAX = 100;
        private int[] vector = new int[MAX];
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEntero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(int.TryParse(this.txtEntero.Text, out int num))
                {
                    //TODO: asignar cada entero al vector
                    if (contador < MAX)
                    {
                        vector[contador] = num;
                        contador++;
                        this.lstVector.Items.Add(num);
                    }
                    this.txtEntero.Text = "";

                }
                else
                {
                    MessageBox.Show("Por favor solo ingresar valores numericos...");
                    this.txtEntero.Focus();
                }
               
            }
            
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int[] x = clases.Ordenacion.ordenaSeleccion(vector, contador);
            //en los metodos estaticos no se necesita crear una instancia de la clase para llamarla 

            //TODO: mostrar el vector ordenado en un lisbox
            this.lstVector.Items.Clear();
            for(int i=0; i<contador; i++)
            {
                this.lstVector.Items.Add(x[i]);
            }
            
        }
    }
}
