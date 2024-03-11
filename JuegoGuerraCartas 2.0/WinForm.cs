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
            btnRepartir.Enabled = false;
            btnJugar.Enabled = false;
            btnCalculaG.Enabled = false;
            lblImgJ1.Visible = false;
            lblImgJ2.Visible = false;
            lblImgJ3.Visible = false;
            lblCartaJ1.Visible = false;
            lblCartaJ2.Visible = false;
            lblCartaJ3.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lblNumJ1.Visible = false;
            lblNumJ2.Visible = false;
            lblNumJ3.Visible = false;
            btnJugar.Visible = false;
            btnCalculaG.Visible = false;
            btnCalculaG.Enabled = false;
        }

        public void btnBarajear_Click(object sender, EventArgs e)
        {
            //Creamos una lista para representar las cartas disponibles
            List<int> naipesDisponibles = new List<int>();

            for (int i = 1; i <= 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    naipesDisponibles.Add(i);
                }
            }

            Random valores = new Random();
            for (int i = 0; i <= 15; i++)
            {
                int temp = naipesDisponibles[i];
                int randomIndex = valores.Next(i, naipesDisponibles.Count);
                naipesDisponibles[i] = naipesDisponibles[randomIndex];
                naipesDisponibles[randomIndex] = temp;
                ColaBarajear.insertar(naipesDisponibles[i]);
            }
            MessageBox.Show("Ya puedes repartir cartas a los jugadores");
            btnBarajear.Enabled = false;
            btnRepartir.Enabled = true;
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
            btnRepartir.Enabled = false;
            btnJugar.Enabled = true;
            btnCalculaG.Enabled = false;
            lblImgJ1.Visible = true;
            lblImgJ2.Visible = true;
            lblImgJ3.Visible = true;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            btnJugar.Visible = true;
            btnCalculaG.Visible = true;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            lblImgJ1.Visible = false;
            lblImgJ2.Visible = false;
            lblImgJ3.Visible = false;
            lblCartaJ1.Visible = true;
            lblCartaJ2.Visible = true;
            lblCartaJ3.Visible = true;

            try
            {
                int CartaJ1 = (int)Jugador1.quitar();
                int CartaJ2 = (int)Jugador2.quitar();
                int CartaJ3 = (int)Jugador3.quitar();

                if(CartaJ1 > CartaJ2 || CartaJ1 == CartaJ2)
                {
                    if (CartaJ1 == CartaJ2)
                    {
                        if (CartaJ1 > CartaJ3)
                        {
                            MostrarNumCarta(CartaJ1, CartaJ2, CartaJ3);
                            CartasGanadasJ1.InsertarCabezaLista(CartaJ1);
                            CartasGanadasJ2.InsertarCabezaLista(CartaJ2);
                            Pozo.InsertarCabezaLista(CartaJ3);
                            MessageBox.Show("DOBLE EMPATE!!! Jugador 3 Perdio esta ronda.");
                        }
                        else
                        {
                            if (CartaJ3 > CartaJ1)
                            {
                                MostrarNumCarta(CartaJ1, CartaJ2, CartaJ3);
                                CartasGanadasJ3.InsertarCabezaLista(CartaJ1);
                                CartasGanadasJ3.InsertarCabezaLista(CartaJ2);
                                CartasGanadasJ3.InsertarCabezaLista(CartaJ3);
                                MessageBox.Show("Jugador 3 GANO esta ronda");
                            }
                            else 
                            {
                                MostrarNumCarta(CartaJ1, CartaJ2, CartaJ3);
                                CartasGanadasJ1.InsertarCabezaLista(CartaJ1);
                                CartasGanadasJ2.InsertarCabezaLista(CartaJ2);
                                CartasGanadasJ3.InsertarCabezaLista(CartaJ3);
                                MessageBox.Show("TRIPLE EMPATE!!!");
                            }
                        }
                    }
                    else
                    {
                        if (CartaJ1==CartaJ3)
                        {
                            MostrarNumCarta(CartaJ1, CartaJ2, CartaJ3);
                            CartasGanadasJ1.InsertarCabezaLista(CartaJ1);
                            CartasGanadasJ3.InsertarCabezaLista(CartaJ3);
                            Pozo.InsertarCabezaLista(CartaJ2);
                            MessageBox.Show("DOBLE EMPATE!!! Jugador 2 Perdio esta ronda.");
                        }
                        else
                        {
                            if (CartaJ1 > CartaJ3)
                            {
                                MostrarNumCarta(CartaJ1, CartaJ2, CartaJ3);
                                CartasGanadasJ1.InsertarCabezaLista(CartaJ1);
                                CartasGanadasJ1.InsertarCabezaLista(CartaJ2);
                                CartasGanadasJ1.InsertarCabezaLista(CartaJ3);
                                MessageBox.Show("Jugador 1 GANO esta ronda");
                            }
                            else
                            {
                                MostrarNumCarta(CartaJ1, CartaJ2, CartaJ3);
                                CartasGanadasJ3.InsertarCabezaLista(CartaJ1);
                                CartasGanadasJ3.InsertarCabezaLista(CartaJ2);
                                CartasGanadasJ3.InsertarCabezaLista(CartaJ3);
                                MessageBox.Show("Jugador 3 GANO esta ronda");
                            }
                        }

                    }
                }
                else
                {
                    if(CartaJ2 > CartaJ3 || CartaJ2==CartaJ3)
                    {
                        if (CartaJ2 > CartaJ3)
                        {
                            MostrarNumCarta(CartaJ1, CartaJ2, CartaJ3);
                            CartasGanadasJ2.InsertarCabezaLista(CartaJ1);
                            CartasGanadasJ2.InsertarCabezaLista(CartaJ2);
                            CartasGanadasJ2.InsertarCabezaLista(CartaJ3);
                            MessageBox.Show("Jugador 2 GANO esta ronda");
                        }
                        else
                        {                           
                                MostrarNumCarta(CartaJ1, CartaJ2, CartaJ3); ;
                                CartasGanadasJ2.InsertarCabezaLista(CartaJ2);
                                CartasGanadasJ3.InsertarCabezaLista(CartaJ3);
                                Pozo.InsertarCabezaLista(CartaJ1);
                                MessageBox.Show("DOBLE EMPATE!!! Jugador 1 Perdio esta ronda.");
                            
                        }
                    }
                    else
                    {
                        MostrarNumCarta(CartaJ1, CartaJ2, CartaJ3);
                        CartasGanadasJ3.InsertarCabezaLista(CartaJ1);
                        CartasGanadasJ3.InsertarCabezaLista(CartaJ2);
                        CartasGanadasJ3.InsertarCabezaLista(CartaJ3);
                        MessageBox.Show("Jugador 3 GANO esta ronda");
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los jugadores ya no tienen cartas!!! \n  Ya puedes calcular el Ganador!!!");
                btnJugar.Enabled = false;
                lblImgJ1.Visible = false;
                lblImgJ2.Visible = false;
                lblImgJ3.Visible = false;
            }
            btnCalculaG.Visible = true;
            btnCalculaG.Enabled = true;
        }

        public void MostrarNumCarta(int CartaJ1, int CartaJ2, int CartaJ3)
        {
            lblNumJ1.Visible = true;
            lblNumJ2.Visible = true;
            lblNumJ3.Visible = true;
            lblNumJ1.BringToFront();
            lblNumJ2.BringToFront();
            lblNumJ3.BringToFront();
            lblNumJ1.Text = CartaJ1.ToString();
            lblNumJ2.Text = CartaJ2.ToString();
            lblNumJ3.Text = CartaJ3.ToString();
        }

        private void btnCalculaG_Click(object sender, EventArgs e)
        {
            int SumJ1 = 0;
            int SumJ2 = 0;
            int SumJ3 = 0;
            int SumP = 0;            
            NodoLista Temp1 = CartasGanadasJ1.Primero;
            NodoLista Temp2 = CartasGanadasJ2.Primero;
            NodoLista Temp3 = CartasGanadasJ3.Primero;
            NodoLista Temp4 = Pozo.Primero;
            while (Temp4 != null)
            {
                SumP = SumP + (int)Temp4.Dato;
                Temp4 = Temp4.Enlace;
            }
            while (Temp1 != null)
            {
                SumJ1 = SumJ1 + (int)Temp1.Dato;
                Temp1 = Temp1.Enlace;
            }
            while (Temp2 != null)
            {
                SumJ2 = SumJ2 + (int)Temp2.Dato;
                Temp2 = Temp2.Enlace;
            }
            while (Temp3 != null)
            {
                SumJ3 = SumJ3 + (int)Temp3.Dato;
                Temp3 = Temp3.Enlace;
            }
            while (Temp3 != null)
            {
                SumJ3 = SumJ3 + (int)Temp3.Dato;
                Temp3 = Temp3.Enlace;
            }
            if (SumJ1 > SumJ2 && SumJ1 > SumJ3)
            {
                MessageBox.Show("El Jugador 1 es el GANADOR con " + SumJ1 + " puntos \n\n Jugador 2 tiene: " + SumJ2 + "\n Jugador 3 tiene: " + SumJ3 + " puntos.\n Pozo : " +SumP+ "\n\n Por favor juega de nuevo!");
            }
            else
            {
                if (SumJ2 > SumJ1 && SumJ2 > SumJ3)
                {
                    MessageBox.Show("El Jugador 2 es el GANADOR con " + SumJ2 + " puntos \n\n Jugador 1 tiene: " + SumJ1 + "\n Jugador 3 tiene: " + SumJ3 + " puntos.\n Pozo : " +SumP+ "\n\n Por favor juega de nuevo!");
                }
                else
                {
                    MessageBox.Show("El Jugador 3 es el GANADOR con " + SumJ3 + " puntos \n\n Jugador 2 tiene: " + SumJ2 + "\n Jugador 1 tiene: " + SumJ1 + " puntos.\n Pozo : " +SumP+ "\n\nPor favor juega de nuevo!");
                }
            }
            btnJugar.Enabled = false;
            btnCalculaG.Enabled = false;
            btnJugar.Visible = false;
            btnCalculaG.Visible = false;
            btnBarajear.Enabled = true;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lblCartaJ1.Visible = false;
            lblCartaJ2.Visible = false;
            lblCartaJ3.Visible = false;
            lblNumJ1.Visible = false;
            lblNumJ2.Visible = false;
            lblNumJ3.Visible = false;
            lblImgJ1.Visible = false;
            lblImgJ2.Visible = false;
            lblImgJ3.Visible = false;
            CartasGanadasJ1.Primero = null;
            CartasGanadasJ2.Primero = null;
            CartasGanadasJ3.Primero = null;
            Pozo.Primero = null;
            Temp1 = null;
            Temp2 = null;
            Temp3 = null;
            Temp4 = null;
            Jugador1.limpiarPila();
            Jugador2.limpiarPila();
            Jugador3.limpiarPila();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
