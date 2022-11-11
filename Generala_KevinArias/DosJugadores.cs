using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Metodos;
using MetodosBD;
using Variables;
using System.Data.OleDb;
namespace Generala_KevinArias
{
    public partial class DosJugadores : Form
    {
        VariablesNoEst VarNoEstaticas = new VariablesNoEst();
        public DosJugadores()
        {
            
            InitializeComponent();
            VarNoEstaticas.listaDeValores.Add(0);
            VarNoEstaticas.listaDeValores.Add(0);
            VarNoEstaticas.listaDeValores.Add(0);
            VarNoEstaticas.listaDeValores.Add(0);
            VarNoEstaticas.listaDeValores.Add(0);
            lbl_jugador1.Text = ClaseVariables.nombreJugador1;
            lbl_jugador2.Text = ClaseVariables.nombreJugador2;
            ClaseVariables.turnoJugadorUno = true;
           
            turnoJugador1();
            lbl_cantidadDeTiros.Text = Convert.ToString("(" + ClaseVariables.cantidadDeTiros + ")");
        }
        MetBD MetodoDB = new MetBD();
        
        public bool pictureAccionado = false;
        public bool pictureAccionado2 = false;
        public bool pictureAccionado3 = false;
        public bool pictureAccionado4 = false;
        public bool pictureAccionado5 = false;
        public bool pictureAccionado6 = false;
    
        public bool picture1 = false;
        public bool picture2 = false;
        public bool picture3 = false;
        public bool picture4 = false;
        public bool picture5 = false;

        public bool controlDeDadosAllanzar = false;


        


        private void turnoJugador1()
        {
            lbl_totalJugadorUno.Text = Convert.ToString(ClaseVariables.puntajeTotalJugador1);
            lbl_totalJugadorDos.Text = Convert.ToString(ClaseVariables.puntajeTotalJugador2);
            if (ClaseVariables.turnoJugadorUno == true)
            {
                lbl_turnoRival.Visible = false;
                lbl_turnoTu.Visible = true;

                
                if (btn_unoTu.Enabled == false)
                {
                    btn_unoTu.Enabled = false;
                    btn_unoTu.Visible = false;
                }
                else if (btn_dosTu.Enabled == false)
                {
                    btn_dosTu.Enabled = false;
                    btn_dosTu.Visible = false;
                }
                else if (btn_tresTu.Enabled == false)
                {
                    btn_tresTu.Enabled = false;
                    btn_tresTu.Visible = false;
                }
                else if (btn_cuatroTu.Enabled == false)
                {
                    btn_cuatroTu.Enabled = false;
                    btn_cuatroTu.Visible = false;
                }
                else if (btn_cincoTu.Enabled == false)
                {
                    btn_cincoTu.Enabled = false;
                    btn_cincoTu.Visible = false;
                }
                else if (btn_seisTu.Enabled == false)
                {
                    btn_seisTu.Enabled = false;
                    btn_seisTu.Visible = false;
                }
                else if (btn_fullTu.Enabled == false)
                {
                    btn_fullTu.Enabled = false;
                    btn_fullTu.Visible = false;
                    
                }
                else if (btn_pokerTu.Enabled == false)
                {
                    btn_pokerTu.Enabled = false;
                    btn_pokerTu.Visible = false;
                }
                else if (btn_escaleraTu.Enabled == false)
                {
                    btn_escaleraTu.Enabled = false;
                    btn_escaleraTu.Visible = false;
                }
                else if (btn_generalaTu.Enabled == false)
                {
                    btn_generalaTu.Enabled = false;
                    btn_generalaTu.Visible = false;
                }
                else if (btn_generalaDobleTu.Enabled == false)
                {
                    btn_generalaDobleTu.Enabled = false;
                    btn_generalaDobleTu.Visible = false;
                }
              


                btn_unoTu.Visible = true;
                btn_dosTu.Visible = true;
                btn_tresTu.Visible = true;
                btn_cuatroTu.Visible = true;
                btn_cincoTu.Visible = true;
                btn_seisTu.Visible = true;
                btn_fullTu.Visible = true;
                btn_pokerTu.Visible = true;
                btn_escaleraTu.Visible = true;
                btn_generalaTu.Visible = true;
                btn_generalaDobleTu.Visible = true;

                btn_unoRival.Visible = false;
                btn_dosRival.Visible = false;
                btn_tresRival.Visible = false;
                btn_cuatroRival.Visible = false;
                btn_cincoRival.Visible = false;
                btn_seisRival.Visible = false;
                btn_fullRival.Visible = false;
                btn_pokerRival.Visible = false;
                btn_escaleraRival.Visible = false;
                btn_generalaRival.Visible = false;
                btn_generalaDobleRival.Visible = false;

                lbl_cantidadDeTiros.Text = Convert.ToString("(" + ClaseVariables.cantidadDeTiros + ")");
                ClaseVariables.contadorDeJugadas = ClaseVariables.contadorDeJugadas + 1;
                ClaseMetodos.FinDeLaPartida();
                Ganador();

            }
            else if (ClaseVariables.turnoJugadorDos == true)
            {
                lbl_turnoTu.Visible = false;
                lbl_turnoRival.Visible = true;

                if (btn_unoRival.Enabled == false)
                {
                    btn_unoRival.Enabled = false;
                    btn_unoRival.Visible = false;
                }
                else if (btn_dosRival.Enabled == false)
                {
                    btn_dosRival.Enabled = false;
                    btn_dosRival.Visible = false;

                }
                else if (btn_tresRival.Enabled == false)
                {
                    btn_tresRival.Enabled = false;
                    btn_tresRival.Visible = false;
                }
                else if (btn_cuatroRival.Enabled == false)
                {
                    btn_cuatroRival.Enabled = false;
                    btn_cuatroRival.Visible = false;
                }
                else if (btn_cincoRival.Enabled == false)
                {
                    btn_cincoRival.Enabled = false;
                    btn_cincoRival.Visible = false;
                }
                else if (btn_seisRival.Enabled == false)
                {
                    btn_seisRival.Enabled = false;
                    btn_seisRival.Visible = false;
                }
                


                btn_unoRival.Visible = true;
                btn_dosRival.Visible = true;
                btn_tresRival.Visible = true;
                btn_cuatroRival.Visible = true;
                btn_cincoRival.Visible = true;
                btn_seisRival.Visible = true;
                btn_fullRival.Visible = true;
                btn_pokerRival.Visible = true;
                btn_escaleraRival.Visible = true;
                btn_generalaRival.Visible = true;
                btn_generalaDobleRival.Visible = true;

                btn_unoTu.Visible = false;
                btn_dosTu.Visible = false;
                btn_tresTu.Visible = false;
                btn_cuatroTu.Visible = false;
                btn_cincoTu.Visible = false;
                btn_seisTu.Visible = false;
                btn_fullTu.Visible = false;
                btn_pokerTu.Visible = false;
                btn_escaleraTu.Visible = false;
                btn_generalaTu.Visible = false;
                btn_generalaDobleTu.Visible = false;

                lbl_cantidadDeTiros.Text = Convert.ToString("(" + ClaseVariables.cantidadDeTiros + ")");
                ClaseVariables.contadorDeJugadas = ClaseVariables.contadorDeJugadas + 1;
               
                ClaseMetodos.FinDeLaPartida();
                Ganador();
            }

        }



        public void limpiarDados()
        {
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;

            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;

            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            VarNoEstaticas.listaDeValores.Count();
            VarNoEstaticas.listaDeValores.RemoveAt(0);

            VarNoEstaticas.listaDeValores.RemoveAt(1);

            VarNoEstaticas.listaDeValores.RemoveAt(2);
            VarNoEstaticas.listaDeValores.RemoveAt(0);
            VarNoEstaticas.listaDeValores.RemoveAt(0);
            VarNoEstaticas.listaDeValores.Count();

            VarNoEstaticas.listaDeValores.Add(0);
            VarNoEstaticas.listaDeValores.Add(0);
            VarNoEstaticas.listaDeValores.Add(0);
            VarNoEstaticas.listaDeValores.Add(0);
            VarNoEstaticas.listaDeValores.Add(0);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;

            


            if (ClaseVariables.turnoJugadorUno || ClaseVariables.turnoJugadorDos)
            {

                ClaseVariables.cantidadDeTiros = ClaseVariables.cantidadDeTiros - 1;

                while (ClaseVariables.cantidadDeTiros >= 0)
                {

                    

                    if (picture1 == false)
                    {
                        timer1.Start();
                       
                    }
                    if (picture2 == false)
                    {
                        timer2.Start();

                    }
                    if (picture3 == false)
                    {
                        timer3.Start();
                    }
                    if (picture4 == false)
                    {
                        timer4.Start();
                    }
                    if (picture5 == false)
                    {
                        timer5.Start();
                    }
                    if (picture1)
                    {
                        timer1.Stop();
                    }
                    if (picture2)
                    {
                        timer2.Stop();
                    }
                    if (picture3)
                    {
                        timer3.Stop();
                    }
                    if (picture4)
                    {
                        timer4.Stop();
                    }
                    if (picture5)
                    {
                        timer5.Stop();
                    }

                    lbl_cantidadDeTiros.Text = Convert.ToString("(" + ClaseVariables.cantidadDeTiros + ")");
                    break;
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random a1 = new Random();
            ClaseVariables.tic = ClaseVariables.tic + 1;
            pictureBox1.Image = imageList1.Images[a1.Next(0, 6)];
            if (ClaseVariables.tic == 6)
            {
                timer1.Stop();
                ClaseVariables.tic = 0;
                ClaseVariables.dado = a1.Next(0, 6);
                pictureBox1.Image = imageList1.Images[ClaseVariables.dado];

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random a2 = new Random();
            ClaseVariables.tic2 = ClaseVariables.tic2 + 1;
            pictureBox2.Image = imageList1.Images[a2.Next(0, 6)];
            if (ClaseVariables.tic2 == 6)
            {
                timer2.Stop();
                ClaseVariables.tic2 = 0;
                ClaseVariables.dado2 = a2.Next(0, 6);
                pictureBox2.Image = imageList1.Images[ClaseVariables.dado2];
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random a3 = new Random();
            ClaseVariables.tic3 = ClaseVariables.tic3 + 1;
            pictureBox3.Image = imageList1.Images[a3.Next(0, 6)];
            if (ClaseVariables.tic3 == 6)
            {
                timer3.Stop();
                ClaseVariables.tic3 = 0;
                ClaseVariables.dado3 = a3.Next(0, 6);
                pictureBox3.Image = imageList1.Images[ClaseVariables.dado3];
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Random a4 = new Random();
            ClaseVariables.tic4 = ClaseVariables.tic4 + 1;
            pictureBox4.Image = imageList1.Images[a4.Next(0, 6)];
            if (ClaseVariables.tic4 == 6)
            {
                timer4.Stop();
                ClaseVariables.tic4 = 0;
                ClaseVariables.dado4 = a4.Next(0, 6);
                pictureBox4.Image = imageList1.Images[ClaseVariables.dado4];
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Random a5 = new Random();
            ClaseVariables.tic5 = ClaseVariables.tic5 + 1;
            pictureBox5.Image = imageList1.Images[a5.Next(0, 6)];
            if (ClaseVariables.tic5 == 6)
            {
                timer5.Stop();
                ClaseVariables.tic5 = 0;
                ClaseVariables.dado5 = a5.Next(0, 6);
                pictureBox5.Image = imageList1.Images[ClaseVariables.dado5];
            }
        }

        private void btn_unoTu_Click(object sender, EventArgs e)
        {

                picture1 = false;
                picture2 = false;
                picture3 = false;
                picture4 = false;
                picture5 = false;
                ClaseMetodos.Uno(VarNoEstaticas.listaDeValores, 1);
                
                
                lbl_tuUno.Text = Convert.ToString(ClaseVariables.puntajeUnoJugador1);
        
                btn_unoTu.Enabled = false;
                btn_unoTu.Visible = false;
                lbl_tuUno.Visible = true;

                ClaseVariables.turnoJugadorUno = false;
                ClaseVariables.turnoJugadorDos = true;
                ClaseVariables.cantidadDeTiros = 3;
                limpiarDados();
                turnoJugador1();
                controlDeDadosAllanzar = true;
                
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureAccionado = true;

            if (pictureAccionado)
            {
                VarNoEstaticas.listaDeValores.RemoveAt(0);
                VarNoEstaticas.listaDeValores.Insert(0, 0);
                pictureBox7.Visible = false;
                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
                pictureAccionado = false;
                picture1 = false;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureAccionado2 = true;

            if (pictureAccionado2)
            {
                VarNoEstaticas.listaDeValores.RemoveAt(1);
                VarNoEstaticas.listaDeValores.Insert(1, 0);

                pictureBox8.Visible = false;
                pictureBox2.Enabled = true;
                pictureBox2.Visible = true;
                pictureAccionado2 = false;
                picture2 = false;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureAccionado3 = true;

            if (pictureAccionado3)
            {
                VarNoEstaticas.listaDeValores.RemoveAt(2);
                VarNoEstaticas.listaDeValores.Insert(2, 0);


                pictureBox9.Visible = false;
                pictureBox3.Enabled = true;
                pictureBox3.Visible = true;
                pictureAccionado3 = false;
                picture3 = false;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureAccionado4 = true;

            if (pictureAccionado4)
            {
                VarNoEstaticas.listaDeValores.RemoveAt(3);
                VarNoEstaticas.listaDeValores.Insert(3, 0);


                pictureBox10.Visible = false;
                pictureBox4.Enabled = true;
                pictureBox4.Visible = true;
                pictureAccionado4 = false;
                picture4 = false;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureAccionado5 = true;

            if (pictureAccionado5)
            {
                VarNoEstaticas.listaDeValores.RemoveAt(4);
                VarNoEstaticas.listaDeValores.Insert(4, 0);

                pictureBox11.Visible = false;
                pictureBox5.Enabled = true;
                pictureBox5.Visible = true;
                pictureAccionado5 = false;
                picture5 = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picture1 = true;
            if (picture1)
            {
                pictureBox1.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox7.Visible = true;
                pictureBox7.Enabled = true;
                pictureBox7.Image = pictureBox1.Image;
               
                
            }

            int res = ClaseMetodos.TraductorDeIndiceAValor(ClaseVariables.dado);

            VarNoEstaticas.listaDeValores.RemoveAt(0);
            VarNoEstaticas.listaDeValores.Insert(0, res);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            picture2 = true;
            if (picture2)
            {
                pictureBox2.Enabled = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = true;
                pictureBox8.Enabled = true;
                pictureBox8.Image = pictureBox2.Image;
                
            }




            int res = ClaseMetodos.TraductorDeIndiceAValor(ClaseVariables.dado2);
            // int res = TraductorDeIndiceAValor(dado2);
            VarNoEstaticas.listaDeValores.RemoveAt(1);
            VarNoEstaticas.listaDeValores.Insert(1, res);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            picture3 = true;
            if (picture3)
            {
                pictureBox3.Enabled = false;
                pictureBox3.Visible = false;
                pictureBox9.Visible = true;
                pictureBox9.Enabled = true;
                pictureBox9.Image = pictureBox3.Image;
                
            }



            int res = ClaseMetodos.TraductorDeIndiceAValor(ClaseVariables.dado3);
            // int res = TraductorDeIndiceAValor(dado3);
            VarNoEstaticas.listaDeValores.RemoveAt(2);
            VarNoEstaticas.listaDeValores.Insert(2, res);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            picture4 = true;

            if (picture4)
            {
                pictureBox4.Enabled = false;
                pictureBox4.Visible = false;
                pictureBox10.Visible = true;
                pictureBox10.Enabled = true;
                pictureBox10.Image = pictureBox4.Image;
                
            }

            int res = ClaseMetodos.TraductorDeIndiceAValor(ClaseVariables.dado4);
            VarNoEstaticas.listaDeValores.RemoveAt(3);
            VarNoEstaticas.listaDeValores.Insert(3, res);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            picture5 = true;

            if (picture5)
            {
                pictureBox5.Enabled = false;
                pictureBox5.Visible = false;
                pictureBox11.Visible = true;
                pictureBox11.Enabled = true;
                pictureBox11.Image = pictureBox5.Image;
                

            }


            int res = ClaseMetodos.TraductorDeIndiceAValor(ClaseVariables.dado5);
            VarNoEstaticas.listaDeValores.RemoveAt(4);
            VarNoEstaticas.listaDeValores.Insert(4, res);
        }

        private void btn_unoRival_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Uno(VarNoEstaticas.listaDeValores, 2);
            ClaseVariables.cantidadDeTiros = 3;
            lbl_rivalUno.Text = Convert.ToString(ClaseVariables.puntajeUnoJugador2);

            btn_unoRival.Enabled = false;
            btn_unoRival.Visible = false;
            lbl_rivalUno.Visible = true;


            ClaseVariables.turnoJugadorDos = false;
            ClaseVariables.turnoJugadorUno = true;
            limpiarDados();
            turnoJugador1();
           

            
        }

       

        private void btn_dosTu_Click(object sender, EventArgs e)
        {
           
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Dos(VarNoEstaticas.listaDeValores, 1);


            lbl_tuDos.Text = Convert.ToString(ClaseVariables.puntajeDosJugador1);
       
            btn_dosTu.Enabled = false;
            btn_dosTu.Visible = false;
            lbl_tuDos.Visible = true;

            ClaseVariables.turnoJugadorUno = false;
            ClaseVariables.turnoJugadorDos = true;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_dosRival_Click(object sender, EventArgs e)
        {
            
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Dos(VarNoEstaticas.listaDeValores, 2);


            lbl_rivalDos.Text = Convert.ToString(ClaseVariables.puntajeDosJugador2);
          
            btn_dosRival.Enabled = false;
            //btn_dosRival.Visible = false;
            lbl_rivalDos.Visible = true;

            ClaseVariables.turnoJugadorUno = true;
            ClaseVariables.turnoJugadorDos = false;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_tresTu_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Tres(VarNoEstaticas.listaDeValores, 1);


            lbl_tresTu.Text = Convert.ToString(ClaseVariables.puntajeTresJugador1);
    
            btn_tresTu.Enabled = false;
            btn_tresTu.Visible = false;
            lbl_tresTu.Visible = true;

            ClaseVariables.turnoJugadorUno = false;
            ClaseVariables.turnoJugadorDos = true;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_tresRival_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Tres(VarNoEstaticas.listaDeValores, 2);


            lbl_rivalTres.Text = Convert.ToString(ClaseVariables.puntajeTresJugador2);
           
            btn_tresRival.Enabled = false;
            btn_tresRival.Visible = false;
            lbl_rivalTres.Visible = true;

            ClaseVariables.turnoJugadorUno = true;
            ClaseVariables.turnoJugadorDos = false;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_cuatroTu_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Cuatro(VarNoEstaticas.listaDeValores, 1);


            lbl_cuatroTu.Text = Convert.ToString(ClaseVariables.puntajeCuatroJugador1);
            btn_cuatroTu.Enabled = false;
            btn_cuatroTu.Visible = false;
            lbl_cuatroTu.Visible = true;

            ClaseVariables.turnoJugadorUno = false;
            ClaseVariables.turnoJugadorDos = true;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_cuatroRival_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Cuatro(VarNoEstaticas.listaDeValores, 2);


            lbl_rivalCuatro.Text = Convert.ToString(ClaseVariables.puntajeCuatroJugador2);
         
            btn_cuatroRival.Enabled = false;
            btn_cuatroRival.Visible = false;
            lbl_rivalCuatro.Visible = true;

            ClaseVariables.turnoJugadorUno = true;
            ClaseVariables.turnoJugadorDos = false;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_cincoTu_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Cinco(VarNoEstaticas.listaDeValores, 1);


            lbl_cincoTu.Text = Convert.ToString(ClaseVariables.puntajeCincoJugador1);
            btn_cincoTu.Enabled = false;
            btn_cincoTu.Visible = false;
            lbl_cincoTu.Visible = true;

            ClaseVariables.turnoJugadorUno = false;
            ClaseVariables.turnoJugadorDos = true;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_cincoRival_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Cinco(VarNoEstaticas.listaDeValores, 2);


            lbl_rivalCinco.Text = Convert.ToString(ClaseVariables.puntajeCincoJugador2);
          
            btn_cincoRival.Enabled = false;
            btn_cincoRival.Visible = false;
            lbl_rivalCinco.Visible = true;

            ClaseVariables.turnoJugadorUno = true;
            ClaseVariables.turnoJugadorDos = false;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_seisTu_Click(object sender, EventArgs e)
        {
           
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Seis(VarNoEstaticas.listaDeValores, 1);


            lbl_seisTu.Text = Convert.ToString(ClaseVariables.puntajeSeisJugador1);
            btn_seisTu.Enabled = false;
            btn_seisTu.Visible = false;
            lbl_seisTu.Visible = true;

            ClaseVariables.turnoJugadorUno = false;
            ClaseVariables.turnoJugadorDos = true;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_seisRival_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Seis(VarNoEstaticas.listaDeValores, 2);


            lbl_rivalSeis.Text = Convert.ToString(ClaseVariables.puntajeSeisJugador2);
           
            btn_seisRival.Enabled = false;
            btn_seisRival.Visible = false;
            lbl_rivalSeis.Visible = true;

            ClaseVariables.turnoJugadorUno = true;
            ClaseVariables.turnoJugadorDos = false;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderColor = Color.FromArgb(254, 55, 200);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderColor = Color.FromArgb(84, 51, 190);
            
        }


   

        private void btn_escaleraTu_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Escalera(VarNoEstaticas.listaDeValores, 1);


            lbl_escaleraTu.Text = Convert.ToString(ClaseVariables.puntajeEscaleraJugador1);
            btn_escaleraTu.Enabled = false;
            btn_escaleraTu.Visible = false;
            lbl_escaleraTu.Visible = true;

            ClaseVariables.turnoJugadorUno = false;
            ClaseVariables.turnoJugadorDos = true;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_escaleraRival_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Escalera(VarNoEstaticas.listaDeValores, 2);


            lbl_escaleraRival.Text = Convert.ToString(ClaseVariables.puntajeEscaleraJugador2);
            btn_escaleraRival.Enabled = false;
            btn_escaleraRival.Visible = false;
            lbl_escaleraRival.Visible = true;

            ClaseVariables.turnoJugadorUno = true;
            ClaseVariables.turnoJugadorDos = false;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1(); 
        }

        private void btn_fullTu_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Full(VarNoEstaticas.listaDeValores, 1);


            lbl_fullTu.Text = Convert.ToString(ClaseVariables.puntajeFullJugador1);
            btn_fullTu.Enabled = false;
            btn_fullTu.Visible = false;
            lbl_fullTu.Visible = true;

            ClaseVariables.turnoJugadorUno = false;
            ClaseVariables.turnoJugadorDos = true;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_fullRival_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Full(VarNoEstaticas.listaDeValores, 2);


            lbl_fullRival.Text = Convert.ToString(ClaseVariables.puntajeFullJugador2);
          
            btn_fullRival.Enabled = false;
            btn_fullRival.Visible = false;
            lbl_fullRival.Visible = true;

            ClaseVariables.turnoJugadorUno = true;
            ClaseVariables.turnoJugadorDos = false;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1(); 
        }

        private void btn_pokerTu_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Poker(VarNoEstaticas.listaDeValores, 1);


            lbl1_pokerTu.Text = Convert.ToString(ClaseVariables.puntajePokerJugador1);
            
           
            btn_pokerTu.Enabled = false;
            btn_pokerTu.Visible = false;
            lbl1_pokerTu.Visible = true;

            ClaseVariables.turnoJugadorUno = false;
            ClaseVariables.turnoJugadorDos = true;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_pokerRival_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.Poker(VarNoEstaticas.listaDeValores, 2);


            lbl_pokerRival.Text = Convert.ToString(ClaseVariables.puntajePokerJugador2);
           
            btn_pokerRival.Enabled = false;
            btn_pokerRival.Visible = false;
            lbl_pokerRival.Visible = true;

            ClaseVariables.turnoJugadorUno = true;
            ClaseVariables.turnoJugadorDos = false;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1(); 
        }

        private void btn_generalaTu_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.JugadaGenerala(VarNoEstaticas.listaDeValores, 1);


            lbl_generalaTu.Text = Convert.ToString(ClaseVariables.puntajeGeneralaJugador1);
        
            btn_generalaTu.Enabled = false;
            btn_generalaTu.Visible = false;
            lbl_generalaTu.Visible = true;

            ClaseVariables.turnoJugadorUno = false;
            ClaseVariables.turnoJugadorDos = true;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_generalaRival_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.JugadaGenerala(VarNoEstaticas.listaDeValores, 2);


            lbl_generalaRival.Text = Convert.ToString(ClaseVariables.puntajeGeneralaJugador2);
          
            btn_generalaRival.Enabled = false;
            btn_generalaRival.Visible = false;
            lbl_generalaRival.Visible = true;

            ClaseVariables.turnoJugadorUno = true;
            ClaseVariables.turnoJugadorDos = false;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1(); 
        }

        private void btn_generalaDobleTu_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.GeneralaDoble(VarNoEstaticas.listaDeValores, 1);


            lbl_generalaDobleTu.Text = Convert.ToString(ClaseVariables.puntajeGeneralaDobleJugador1);
            btn_generalaDobleTu.Enabled = false;
            btn_generalaDobleTu.Visible = false;
            lbl_generalaDobleTu.Visible = true;

            ClaseVariables.turnoJugadorUno = false;
            ClaseVariables.turnoJugadorDos = true;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1();
        }

        private void btn_generalaDobleRival_Click(object sender, EventArgs e)
        {
            
            picture1 = false;
            picture2 = false;
            picture3 = false;
            picture4 = false;
            picture5 = false;
            ClaseMetodos.GeneralaDoble(VarNoEstaticas.listaDeValores, 2);


            lbl_generalaDobleRival.Text = Convert.ToString(ClaseVariables.puntajeGeneralaDobleJugador2);
        
            btn_generalaDobleRival.Enabled = false;
            btn_generalaDobleRival.Visible = false;
            lbl_generalaDobleRival.Visible = true;

            ClaseVariables.turnoJugadorUno = true;
            ClaseVariables.turnoJugadorDos = false;
            ClaseVariables.cantidadDeTiros = 3;
            limpiarDados();
            turnoJugador1(); 
        }


        private void Ganador()
        {
            bool Alta = false;
            if (ClaseVariables.ganoJugador1)
            {
                ShowDialogGanaste fganaste = new ShowDialogGanaste(ClaseVariables.nombreJugador1);
                DialogResult res = fganaste.ShowDialog();

                if (res == DialogResult.OK)
                {
                    Alta = MetodoDB.ABM("INSERT INTO Puntaje (Nombre, Puntaje) VALUES ('" + ClaseVariables.nombreJugador1 + "', '" + ClaseVariables.puntajeTotalJugador1 + "')");
                    limpiarTodo();
                    this.Close();
                }
                
            }
            else if(ClaseVariables.ganoJugador2)
            {
                ShowDialogGanaste fganaste = new ShowDialogGanaste(ClaseVariables.nombreJugador2);
                DialogResult res = fganaste.ShowDialog();
                if (res == DialogResult.OK)
                {
                    Alta = MetodoDB.ABM("INSERT INTO Puntaje (Nombre, Puntaje) VALUES ('" + ClaseVariables.nombreJugador2 + "', '" + ClaseVariables.puntajeTotalJugador2 + "')");
                    limpiarTodo();
                    this.Close();
                }
       
                
            }
            else if (ClaseVariables.empate)
            {
                ShowDialogEmpate fempate = new ShowDialogEmpate();
                DialogResult res = fempate.ShowDialog();
                if (res == DialogResult.OK)
                {
                    limpiarTodo();
                    this.Close();
                }
                
            }
        }

        private void btn_rendirse_Click(object sender, EventArgs e)
        {
            bool Alta = false;
            if (ClaseVariables.turnoJugadorUno == true)
            {
                ShowDialogGanaste fganaste = new ShowDialogGanaste(ClaseVariables.nombreJugador2);
                DialogResult res = fganaste.ShowDialog();
                if (res == DialogResult.OK)
                {
                   
                    Alta = MetodoDB.ABM("INSERT INTO Puntaje (Nombre, Puntaje) VALUES ('" + ClaseVariables.nombreJugador2 + "', '" + ClaseVariables.puntajeTotalJugador2 + "')");
                    limpiarTodo();
                    this.Close();
                }
                
            }
            else if (ClaseVariables.turnoJugadorDos == true)
            {
                ShowDialogGanaste fganaste = new ShowDialogGanaste(ClaseVariables.nombreJugador1);
                DialogResult res = fganaste.ShowDialog();
                if (res == DialogResult.OK)
                {
                   
                    Alta = MetodoDB.ABM("INSERT INTO Puntaje (Nombre, Puntaje) VALUES ('" + ClaseVariables.nombreJugador1 + "', '" + ClaseVariables.puntajeTotalJugador1 + "')");
                    limpiarTodo();
                    this.Close();

                }
               
                
            }
        }


        private void limpiarTodo()
        {
           ClaseVariables.puntajeTotalJugador1 = 0;

        ClaseVariables.puntajeTotalJugador2 = 0;
        ClaseVariables.cantidadDeTiros = 3;
        ClaseVariables.puntajeUnoJugador1 = 0;
        ClaseVariables. puntajeDosJugador1 = 0;
        ClaseVariables.puntajeTresJugador1 = 0;
        ClaseVariables.puntajeCuatroJugador1 = 0;
        ClaseVariables.puntajeCincoJugador1 = 0;
       ClaseVariables.puntajeSeisJugador1 = 0;

        ClaseVariables.puntajeGeneralaJugador1 = 0;
        ClaseVariables.puntajeGeneralaDobleJugador1 = 0;
        ClaseVariables.puntajeEscaleraJugador1 = 0;
        ClaseVariables.puntajeFullJugador1 = 0;
        ClaseVariables.puntajePokerJugador1 = 0;

        ClaseVariables.ganoJugador1 = false;
        ClaseVariables.ganoJugador2 = false;
        ClaseVariables.empate = false;
        ClaseVariables.contadorDeJugadas = 0;

        ClaseVariables.turnoJugadorUno = false;
        ClaseVariables.turnoJugadorDos = false;



        ClaseVariables.puntajeUnoJugador2 = 0;
        ClaseVariables.puntajeDosJugador2 = 0;
        ClaseVariables.puntajeTresJugador2 = 0;
        ClaseVariables.puntajeCuatroJugador2 = 0;
        ClaseVariables.puntajeCincoJugador2 = 0;
        ClaseVariables.puntajeSeisJugador2 = 0;

        ClaseVariables.puntajeGeneralaJugador2 = 0;
        ClaseVariables.puntajeGeneralaDobleJugador2 = 0;
        ClaseVariables.puntajeEscaleraJugador2 = 0;
        ClaseVariables.puntajeFullJugador2 = 0;
        ClaseVariables.puntajePokerJugador2 = 0;

        btn_unoTu.Enabled = true;
        btn_dosTu.Enabled = true;
        btn_tresTu.Enabled = true;
        btn_cuatroTu.Enabled = true;
        btn_cincoTu.Enabled = true;
        btn_seisTu.Enabled = true;
        btn_fullTu.Enabled = true;
        btn_pokerTu.Enabled = true;
        btn_escaleraTu.Enabled = true;
        btn_generalaTu.Enabled = true;
        btn_generalaDobleTu.Enabled = true;

        btn_unoRival.Enabled = false;
        btn_dosRival.Enabled = false;
        btn_tresRival.Enabled = false;
        btn_cuatroRival.Enabled = false;
        btn_cincoRival.Enabled = false;
        btn_seisRival.Enabled = false;
        btn_fullRival.Enabled = false;
        btn_pokerRival.Enabled = false;
        btn_escaleraRival.Enabled = false;
        btn_generalaRival.Enabled = false;
        btn_generalaDobleRival.Enabled = false;
            
        }

        private void btn_rendirse_MouseEnter(object sender, EventArgs e)
        {
            btn_rendirse.ForeColor = Color.White;
            btn_rendirse.BackColor = Color.FromArgb(214, 69, 98);
            btn_rendirse.FlatAppearance.BorderSize = 1;
        }

        private void btn_rendirse_MouseLeave(object sender, EventArgs e)
        {
            btn_rendirse.ForeColor = Color.FromArgb(214, 69,  98);
            btn_rendirse.BackColor = Color.Transparent;
            
        }

  



        
    }
}
