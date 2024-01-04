using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        Cola miCola = new Cola();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (txtNombreNodo.Text.Length==0)
            {
                MessageBox.Show("Debe ingresar un nombre de nodo valido.");
            }
            else
            {
                Nodo unNuevoNodo=new Nodo();
                unNuevoNodo.Nombre=txtNombreNodo.Text;
                miCola.Encolar(unNuevoNodo);
                MostrarCola();
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (miCola.Vacia())
            {
                MessageBox.Show("La cola esta vacia");
            }
            else
            {
                miCola.Desencolar();
                MostrarCola();
            }
        }


        private void MostrarCola()
        {
            lstCola.Items.Clear();
            MostrarNodoEnPantalla(miCola.Inicio);

        }

        private void MostrarNodoEnPantalla(Nodo unNodo)
        {
            if (unNodo != null)
            {
                lstCola.Items.Add(unNodo.Nombre);

                if (unNodo.Siguiente != null)
                {
                    MostrarNodoEnPantalla(unNodo.Siguiente);
                }

            } 
                
            
        }
    }
}
