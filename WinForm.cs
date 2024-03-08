using EstructuraDeClases.Cola;
using EstructuraDeClases.Listas;
using EstructuraDeClases.Pilas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoGuerraCartas
{
    public partial class WinForm : Form
    {
        //Cola utilizada para Barajear los naipes y contendra 15
        ColaLista ColaBarajear = new ColaLista();

        //Pilas usadas para contener las cartas con las que jugaran los jugadores, son 5 por Pila.
        Pila Jugador1 = new Pila();
        Pila Jugador2 = new Pila();
        Pila Jugador3 = new Pila();

        //Listas usadas para guardar las cartas ganas para cada jugador.
        Lista CartasGanadasJ1 = new Lista();
        Lista CartasGanadasJ2 = new Lista();
        Lista CartasGanadasJ3 = new Lista();

        //Lista que servira como Pozo cuando haya empates
        Lista Pozo = new Lista();
        public WinForm()
        {
            InitializeComponent();
        }

        public void btnBarajear_Click(object sender, EventArgs e)
        {
            //Creamos una lista para representar las cartas disponibles
            List<int> naipesDisponibles = new List<int>();

            // Agregamos los naipes del 1 al 13 cuatro veces cada uno
            for (int i = 1; i <= 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    naipesDisponibles.Add(i);
                }
            }

            //Barajeamos las cartas y las agregamos a la cola ColaBarajear
            Random valores = new Random();
            for (int i = 0; i <= 15; i++)
            {
                int temp = naipesDisponibles[i];
                int randomIndex = valores.Next(i, naipesDisponibles.Count);
                naipesDisponibles[i] = naipesDisponibles[randomIndex];
                naipesDisponibles[randomIndex] = temp;
                ColaBarajear.insertar(naipesDisponibles[i]);
            }
        }

        public void btnRepartir_Click(object sender, EventArgs e)
        {
            int PilaActual = 1;
            try
            {

                while (ColaBarajear != null)
                {
                    switch (PilaActual)
                    {
                        case 1:
                            Jugador1.insertar(ColaBarajear.quitar());
                            break;
                        case 2:
                            Jugador2.insertar(ColaBarajear.quitar());
                            break;
                        case 3:
                            Jugador3.insertar(ColaBarajear.quitar());
                            break;
                    }
                    PilaActual = (PilaActual % 3) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Las cartas han sido repartidas exitosamente.");
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            int CartaJ1 = (int)Jugador1.quitar();
            int CartaJ2 = (int)Jugador2.quitar();
            int CartaJ3 = (int)Jugador3.quitar();
            try
            {

                if ((CartaJ1 == CartaJ2) && (CartaJ1 == CartaJ3) && (CartaJ2 == CartaJ3))
                {
                    CartasGanadasJ1.InsertarCabezaLista(CartaJ1);
                    CartasGanadasJ2.InsertarCabezaLista(CartaJ2);
                    CartasGanadasJ3.InsertarCabezaLista(CartaJ3);
                }
                else
                {
                    if (CartaJ1 == CartaJ2 && CartaJ2 != CartaJ3)
                    {
                        CartasGanadasJ1.InsertarCabezaLista(CartaJ1);
                        CartasGanadasJ2.InsertarCabezaLista(CartaJ2);
                        Pozo.InsertarCabezaLista(CartaJ3);
                    }
                    else
                    {
                        if (CartaJ1 == CartaJ3 && CartaJ3 != CartaJ2)
                        {
                            CartasGanadasJ1.InsertarCabezaLista(CartaJ1);
                            CartasGanadasJ3.InsertarCabezaLista(CartaJ3);
                            Pozo.InsertarCabezaLista(CartaJ2);
                        }
                        else
                        {
                            if (CartaJ2 == CartaJ3 && CartaJ3 != CartaJ1)
                            {
                                CartasGanadasJ2.InsertarCabezaLista(CartaJ2);
                                CartasGanadasJ3.InsertarCabezaLista(CartaJ3);
                                Pozo.InsertarCabezaLista(CartaJ1);
                            }
                            else
                            {
                                if (CartaJ1 > CartaJ2 && CartaJ1 > CartaJ3)
                                {
                                    CartasGanadasJ1.InsertarCabezaLista(CartaJ1);
                                    CartasGanadasJ1.InsertarCabezaLista(CartaJ2);
                                    CartasGanadasJ1.InsertarCabezaLista(CartaJ3);
                                }
                                else
                                {
                                    if (CartaJ2 > CartaJ1 && CartaJ2 > CartaJ3)
                                    {
                                        CartasGanadasJ2.InsertarCabezaLista(CartaJ1);
                                        CartasGanadasJ2.InsertarCabezaLista(CartaJ2);
                                        CartasGanadasJ2.InsertarCabezaLista(CartaJ3);
                                    }
                                    else
                                    {
                                        CartasGanadasJ3.InsertarCabezaLista(CartaJ1);
                                        CartasGanadasJ3.InsertarCabezaLista(CartaJ2);
                                        CartasGanadasJ3.InsertarCabezaLista(CartaJ3);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los jugadores ya no tienen cartas!!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
