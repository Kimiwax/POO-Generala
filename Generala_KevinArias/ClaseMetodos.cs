using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Variables;
using System.Data.OleDb;

namespace Metodos
{
    public static class ClaseMetodos
    {



        public static int TraductorDeIndiceAValor(int elemento)
        {
            switch (elemento)
            {
                case 0:
                    {
                        elemento = 1;
                        break;
                    }
                case 1:
                    {
                        elemento = 2;
                        break;
                    }
                case 2:
                    {
                        elemento = 3;
                        break;
                    }
                case 3:
                    {
                        elemento = 4;
                        break;
                    }
                case 4:
                    {
                        elemento = 5;
                        break;
                    }
                case 5:
                    {
                        elemento = 6;
                        break;
                    }

            }
            return elemento;
        }


        public static void turnoJugadorUno(string a)
        {
            
        }





















        public static void Uno(List<int> a, int player)
        {
            int unoPlayer1 = 0;
            int unoPlayer2 = 0;

            switch (player)
            {
                case 1:
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] == 1)
                        {
                            unoPlayer1 = unoPlayer1 + 1;
                        }

                    }
                    break;
                case 2:
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] == 1)
                        {
                            unoPlayer2 = unoPlayer2 + 1;
                        }

                    }
                    break;
            }
            
            ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + unoPlayer1;
            ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + unoPlayer2;
            ClaseVariables.puntajeUnoJugador1 = unoPlayer1;
            ClaseVariables.puntajeUnoJugador2 = unoPlayer2;

        }

        public static void Dos(List<int> a, int player)
        {
            int dosPlayer1 = 0;
            int dosPlayer2 = 0;


            switch (player)
            {
                case 1:
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] == 2)
                        {
                            dosPlayer1 = dosPlayer1 + 1;
                        }

                    }
                    break;
                case 2:
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] == 2)
                        {
                            dosPlayer2 = dosPlayer2 + 1;
                        }

                    }
                    break;
            }


            ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + (dosPlayer1 * 2);
            ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + (dosPlayer2 * 2);
            ClaseVariables.puntajeDosJugador1 = (dosPlayer1 * 2);
            ClaseVariables.puntajeDosJugador2 = (dosPlayer2 * 2);
        }

        public static void Tres(List<int> a, int player)
        {

            int tresPlayer1 = 0;
            int tresPlayer2 = 0;


            switch (player)
            {
                case 1:
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] == 3)
                        {
                            tresPlayer1 = tresPlayer1 + 1;
                        }

                    }
                    break;
                case 2:
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] == 3)
                        {
                            tresPlayer2 = tresPlayer2 + 1;
                        }

                    }
                    break;
            }

            ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + (tresPlayer1 * 3);
            ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + (tresPlayer2 * 3);
            ClaseVariables.puntajeTresJugador1 = (tresPlayer1 * 3);
            ClaseVariables.puntajeTresJugador2 = (tresPlayer2 * 3);


           
        }


        public static void Cuatro(List<int> a, int player)
        {
            int cuatroPlayer1 = 0;
            int cuatroPlayer2 = 0;


            switch (player)
            {
                case 1:
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] == 4)
                        {
                           cuatroPlayer1 = cuatroPlayer1 + 1;
                        }

                    }
                    break;
                case 2:
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] == 4)
                        {
                            cuatroPlayer2 = cuatroPlayer2 + 1;
                        }

                    }
                    break;
            }

            ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + (cuatroPlayer1 * 4);
            ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + (cuatroPlayer2 * 4);
            ClaseVariables.puntajeCuatroJugador1 = (cuatroPlayer1 * 4);
            ClaseVariables.puntajeCuatroJugador2 = (cuatroPlayer2 * 4);
        }


        public static void Cinco(List<int> a, int player)
        {
            int cincoPlayer1 = 0;
            int cincoPlayer2 = 0;


            switch (player)
            {
                case 1:
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] == 5)
                        {
                            cincoPlayer1 = cincoPlayer1 + 1;
                        }

                    }
                    break;
                case 2:
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] == 5)
                        {
                            cincoPlayer2 = cincoPlayer2 + 1;
                        }

                    }
                    break;
            }

            ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + (cincoPlayer1 * 5);
            ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + (cincoPlayer2 * 5);
            ClaseVariables.puntajeCincoJugador1 = (cincoPlayer1 * 5);
            ClaseVariables.puntajeCincoJugador2 = (cincoPlayer2 * 5);
        }


       public static void Seis(List<int> a, int player)
        {
            int seisPlayer1 = 0;
            int seisPlayer2 = 0;


            switch (player)
            {
                case 1:
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] == 6)
                        {
                            seisPlayer1 = seisPlayer1 + 1;
                        }

                    }
                    break;
                case 2:
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] == 6)
                        {
                            seisPlayer2 = seisPlayer2 + 1;
                        }

                    }
                    break;
            }

            ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + (seisPlayer1 * 6);
            ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + (seisPlayer2 * 6);
            ClaseVariables.puntajeSeisJugador1 = (seisPlayer1 * 6);
            ClaseVariables.puntajeSeisJugador2 = (seisPlayer2 * 6);
        }




        public static void JugadaGenerala(List<int>listaDeDados, int player)
        {
            switch (player)
            {
                case 1:
                    if ((listaDeDados[0] == listaDeDados[1] && listaDeDados[2] == listaDeDados[3] && listaDeDados[4] == listaDeDados[1]) && (listaDeDados[0] != 0 && listaDeDados[1] != 0 && listaDeDados[2] != 0 && listaDeDados[3] != 0 && listaDeDados[4] != 0))
                    {

                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 50;
                        ClaseVariables.puntajeGeneralaJugador1 = 50;
                    }
                    else
                    {

                    }
                    break;
                case 2:
                    if ((listaDeDados[0] == listaDeDados[1] && listaDeDados[2] == listaDeDados[3] && listaDeDados[4] == listaDeDados[1])&& (listaDeDados[0] != 0 && listaDeDados[1] != 0 && listaDeDados[2] != 0 && listaDeDados[3] != 0 && listaDeDados[4] != 0))
                    {

                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 50;
                        ClaseVariables.puntajeGeneralaJugador2 = 50;
                    }
                    else
                    {

                    }
                    break;
            }
            
            
        }


        public static void GeneralaDoble(List<int> a, int player)
        {

            switch (player)
            {
                case 1:
                    if ((a[0] == a[1] && a[2] == a[3] && a[4] == a[1]) && (a[0] != 0 && a[1] != 0 && a[2] != 0 && a[3] != 0 && a[4] != 0))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 50;
                        ClaseVariables.puntajeGeneralaDobleJugador1 = 50;
                    }
                    break;

                case 2:
                    if ((a[0] == a[1] && a[2] == a[3] && a[4] == a[1]) && (a[0] != 0 && a[1] != 0 && a[2] != 0 && a[3] != 0 && a[4] != 0))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 50;
                        ClaseVariables.puntajeGeneralaDobleJugador2 = 50;
                    }
                    break;
            }


            
            

        }


        public static void Escalera(List<int> a, int player)
        {

            switch (player)
            {
                case 1:
                    if (a.Contains(1) && a.Contains(2) && a.Contains(3) && a.Contains(4) && a.Contains(5))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 20;
                        ClaseVariables.puntajeEscaleraJugador1 = 20;
                    }
                    else if (a.Contains(2) && a.Contains(3) && a.Contains(4) && a.Contains(5) && a.Contains(6))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 20;
                        ClaseVariables.puntajeEscaleraJugador1 = 20;
                    }
                    else if (a.Contains(1) && a.Contains(3) && a.Contains(4) && a.Contains(5) && a.Contains(6))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 20;
                        ClaseVariables.puntajeEscaleraJugador1 = 20;
                    }
                    break;
                case 2:
                    if (a.Contains(1) && a.Contains(2) && a.Contains(3) && a.Contains(4) && a.Contains(5))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 20;
                        ClaseVariables.puntajeEscaleraJugador2 = 20;
                    }
                    else if (a.Contains(2) && a.Contains(3) && a.Contains(4) && a.Contains(5) && a.Contains(6))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 20;
                        ClaseVariables.puntajeEscaleraJugador2 = 20;
                    }
                    else if (a.Contains(1) && a.Contains(3) && a.Contains(4) && a.Contains(5) && a.Contains(6))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 20;
                        ClaseVariables.puntajeEscaleraJugador2 = 20;
                    }
                    break;
            }
            
            
        }


        public static void Full(List<int> a, int player)
        {
            int uno = 0;
            int dos = 0;
            int tres = 0;
            int cuatro = 0;
            int cinco = 0;
            int seis = 0;



            for (int i = 0; i < a.Count; i++)
            {

                if (a[i] == 1)
                {
                    uno = uno + 1;
                }

                if (a[i] == 2)
                {
                    dos = dos + 1;
                }
                if (a[i] == 3)
                {
                    tres = tres + 1;
                }
                if (a[i] == 4)
                {
                    cuatro = cuatro + 1;
                }
                if (a[i] == 5)
                {
                    cinco = cinco + 1;
                }
                if (a[i] == 6)
                {
                    seis = seis + 1;
                }

            }

            

            switch (player)
            {
                case 1:
                    if ((uno == 3 && dos == 2) || (uno == 3 && tres == 2) || (uno == 3 && cuatro == 2) || (uno == 3 && cinco == 2) || (uno == 3 && seis == 2))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 30;
                        ClaseVariables.puntajeFullJugador1 = 30;
                    }
                    else if ((dos == 3 && uno == 2) || (dos == 3 && tres == 2) || (dos == 3 && cuatro == 2) || (dos == 3 && cinco == 2) || (dos == 3 && seis == 2))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 30;
                        ClaseVariables.puntajeFullJugador1 = 30;
                    }
                    else if ((tres == 3 && uno == 2) || (tres == 3 && dos == 2) || (tres == 3 && cuatro == 2) || (tres == 3 && cinco == 2) || (tres == 3 && seis == 2))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 30;
                        ClaseVariables.puntajeFullJugador1 = 30;
                    }
                    else if ((cuatro == 3 && uno == 2) || (cuatro == 3 && dos == 2) || (cuatro == 3 && tres == 2) || (cuatro == 3 && cinco == 2) || (cuatro == 3 && seis == 2))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 30;
                        ClaseVariables.puntajeFullJugador1 = 30;
                    }
                    else if ((cinco == 3 && uno == 2) || (cinco == 3 && dos == 2) || (cinco == 3 && tres == 2) || (cinco == 3 && cuatro == 2) || (cinco == 3 && seis == 2))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 30;
                        ClaseVariables.puntajeFullJugador1 = 30;
                    }
                    else if ((seis == 3 && uno == 2) || (seis == 3 && dos == 2) || (seis == 3 && tres == 2) || (seis == 3 && cuatro == 2) || (seis == 3 && cinco == 2))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 30;
                        ClaseVariables.puntajeFullJugador1 = 30;
                    }

                    break;
                case 2:
                    if ((uno == 3 && dos == 2) || (uno == 3 && tres == 2) || (uno == 3 && cuatro == 2) || (uno == 3 && cinco == 2) || (uno == 3 && seis == 2))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 30;
                        ClaseVariables.puntajeFullJugador2 = 30;
                    }
                    else if ((dos == 3 && uno == 2) || (dos == 3 && tres == 2) || (dos == 3 && cuatro == 2) || (dos == 3 && cinco == 2) || (dos == 3 && seis == 2))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 30;
                        ClaseVariables.puntajeFullJugador2 = 30;
                    }
                    else if ((tres == 3 && uno == 2) || (tres == 3 && dos == 2) || (tres == 3 && cuatro == 2) || (tres == 3 && cinco == 2) || (tres == 3 && seis == 2))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 30;
                        ClaseVariables.puntajeFullJugador2 = 30;
                    }
                    else if ((cuatro == 3 && uno == 2) || (cuatro == 3 && dos == 2) || (cuatro == 3 && tres == 2) || (cuatro == 3 && cinco == 2) || (cuatro == 3 && seis == 2))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 30;
                        ClaseVariables.puntajeFullJugador2 = 30;
                    }
                    else if ((cinco == 3 && uno == 2) || (cinco == 3 && dos == 2) || (cinco == 3 && tres == 2) || (cinco == 3 && cuatro == 2) || (cinco == 3 && seis == 2))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 30;
                        ClaseVariables.puntajeFullJugador2 = 30;
                    }
                    else if ((seis == 3 && uno == 2) || (seis == 3 && dos == 2) || (seis == 3 && tres == 2) || (seis == 3 && cuatro == 2) || (seis == 3 && cinco == 2))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 30;
                        ClaseVariables.puntajeFullJugador2 = 30;
                    }
                    break;

            }
        }



        public static void Poker(List<int> a, int player)
        {
            int uno = 0;
            int dos = 0;
            int tres = 0;
            int cuatro = 0;
            int cinco = 0;
            int seis = 0;


            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == 1)
                {
                    uno = uno + 1;
                }

                if (a[i] == 2)
                {
                    dos = dos + 1;
                }
                if (a[i] == 3)
                {
                    tres = tres + 1;
                }
                if (a[i] == 4)
                {
                    cuatro = cuatro + 1;
                }
                if (a[i] == 5)
                {
                    cinco = cinco + 1;
                }
                if (a[i] == 6)
                {
                    seis = seis + 1;
                }

            }

            switch (player)
            {
                case 1:
                    if ((uno == 4 && dos == 1) || (uno == 4 && tres == 1) || (uno == 4 && cuatro == 1) || (uno == 4 && cinco == 1) || (uno == 4 && seis == 1))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 40;
                        ClaseVariables.puntajePokerJugador1 = 40;
                    }
                    else if ((dos == 4 && uno == 1) || (dos == 4 && tres == 1) || (dos == 4 && cuatro == 1) || (dos == 4 && cinco == 1) || (dos == 4 && seis == 1))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 40;
                        ClaseVariables.puntajePokerJugador1 = 40;
                    }
                    else if ((tres == 4 && dos == 1) || (tres == 4 && uno == 1) || (tres == 4 && cuatro == 1) || (tres == 4 && cinco == 1) || (tres == 4 && seis == 1))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 40;
                        ClaseVariables.puntajePokerJugador1 = 40;
                    }
                    else if ((cuatro == 4 && dos == 1) || (cuatro == 4 && tres == 1) || (cuatro == 4 && uno == 1) || (cuatro == 4 && cinco == 1) || (cuatro == 4 && seis == 1))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 40;
                        ClaseVariables.puntajePokerJugador1 = 40;
                    }
                    else if ((cinco == 4 && dos == 1) || (cinco == 4 && tres == 1) || (cinco == 4 && cuatro == 1) || (cinco == 4 && uno == 1) || (cinco == 4 && seis == 1))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 40;
                        ClaseVariables.puntajePokerJugador1 = 40;
                    }
                    else if ((seis == 4 && dos == 1) || (seis == 4 && tres == 1) || (seis == 4 && cuatro == 1) || (seis == 4 && cinco == 1) || (seis == 4 && uno == 1))
                    {
                        ClaseVariables.puntajeTotalJugador1 = ClaseVariables.puntajeTotalJugador1 + 40;
                        ClaseVariables.puntajePokerJugador1 = 40;
                    }
                    break;
                case 2:
                    if ((uno == 4 && dos == 1) || (uno == 4 && tres == 1) || (uno == 4 && cuatro == 1) || (uno == 4 && cinco == 1) || (uno == 4 && seis == 1))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 40;
                        ClaseVariables.puntajePokerJugador2 = 40;
                    }
                    else if ((dos == 4 && uno == 1) || (dos == 4 && tres == 1) || (dos == 4 && cuatro == 1) || (dos == 4 && cinco == 1) || (dos == 4 && seis == 1))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 40;
                        ClaseVariables.puntajePokerJugador2 = 40;
                    }
                    else if ((tres == 4 && dos == 1) || (tres == 4 && uno == 1) || (tres == 4 && cuatro == 1) || (tres == 4 && cinco == 1) || (tres == 4 && seis == 1))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 40;
                        ClaseVariables.puntajePokerJugador2 = 40;
                    }
                    else if ((cuatro == 4 && dos == 1) || (cuatro == 4 && tres == 1) || (cuatro == 4 && uno == 1) || (cuatro == 4 && cinco == 1) || (cuatro == 4 && seis == 1))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 40;
                        ClaseVariables.puntajePokerJugador2 = 40;
                    }
                    else if ((cinco == 4 && dos == 1) || (cinco == 4 && tres == 1) || (cinco == 4 && cuatro == 1) || (cinco == 4 && uno == 1) || (cinco == 4 && seis == 1))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 40;
                        ClaseVariables.puntajePokerJugador2 = 40;
                    }
                    else if ((seis == 4 && dos == 1) || (seis == 4 && tres == 1) || (seis == 4 && cuatro == 1) || (seis == 4 && cinco == 1) || (seis == 4 && uno == 1))
                    {
                        ClaseVariables.puntajeTotalJugador2 = ClaseVariables.puntajeTotalJugador2 + 40;
                        ClaseVariables.puntajePokerJugador2 = 40;
                    }
                    break;
            }
            
            

        }



        public static void FinDeLaPartida()
        {

            if (ClaseVariables.contadorDeJugadas == 23 && ClaseVariables.puntajeTotalJugador1 > ClaseVariables.puntajeTotalJugador2)
            {
                ClaseVariables.ganoJugador1 = true;
            }
            else if (ClaseVariables.contadorDeJugadas == 23 && ClaseVariables.puntajeTotalJugador2 > ClaseVariables.puntajeTotalJugador1)
            {
                ClaseVariables.ganoJugador2 = true;
            }
            else if (ClaseVariables.contadorDeJugadas == 23 && (ClaseVariables.puntajeTotalJugador1 == ClaseVariables.puntajeTotalJugador2 || ClaseVariables.puntajeTotalJugador2 == ClaseVariables.puntajeTotalJugador1))
            {
                ClaseVariables.empate = true;
            }
            
        }


     

       
    }
}
