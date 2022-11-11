using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Variables;

namespace Generala_KevinArias
{
    public partial class MenuDosJugadores : Form
    {
        public MenuDosJugadores()
        {
            InitializeComponent();
            pictureBox1.Parent = pictureBox3;
            pictureBox2.Parent = pictureBox3;
            lbl_jugador1.Parent = pictureBox3;
            lbl_jugador2.Parent = pictureBox3;
            txt_jugador1.Parent = pictureBox3;
            txt_jugador2.Parent = pictureBox3;
            btn_jugar.Parent = pictureBox3;
            btn_atras.Parent = pictureBox3;
            panel1.Parent = pictureBox3;
            panel2.Parent = pictureBox3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_jugador1.Text != "" && txt_jugador2.Text != "")
            {
                Variables.ClaseVariables.nombreJugador1 = txt_jugador1.Text;
                Variables.ClaseVariables.nombreJugador2 = txt_jugador2.Text;

                DosJugadores juegoDosJugadores = new DosJugadores();
                this.Visible = false;
                juegoDosJugadores.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Todos los jugadores deben elegir su nombre");
            }
           
            
            
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_jugar_MouseEnter(object sender, EventArgs e)
        {
            btn_jugar.ForeColor = Color.FromArgb(230, 36, 175);
            btn_jugar.FlatAppearance.BorderSize = 1;
        }

        private void btn_jugar_MouseLeave(object sender, EventArgs e)
        {
            btn_jugar.ForeColor = Color.FromArgb(231, 242, 18);
            btn_jugar.FlatAppearance.BorderSize = 0;
        }

        private void btn_atras_MouseEnter(object sender, EventArgs e)
        {
            btn_atras.ForeColor = Color.FromArgb(230, 36, 175);
            btn_atras.FlatAppearance.BorderSize = 1;
        }

        private void btn_atras_MouseLeave(object sender, EventArgs e)
        {
            btn_atras.ForeColor = Color.FromArgb(231, 242, 18);
            btn_atras.FlatAppearance.BorderSize = 0;
        }

        private void txt_jugador1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                // Se pulsó la tecla Enter
                e.Handled = true;

            }
            else if (e.KeyChar == Convert.ToChar(8))
            {
                // Se pulso la tecla retroceso
                e.Handled = false;
            }
            else if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
               
            }


        }

        private void txt_jugador2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                // Se pulsó la tecla Enter
                e.Handled = true;

            }
            else if (e.KeyChar == Convert.ToChar(8))
            {
                // Se pulso la tecla retroceso
                e.Handled = false;
            }
            else if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }
    }
}
