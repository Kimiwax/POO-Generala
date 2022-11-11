using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generala_KevinArias
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
            pictureBox1.Parent = pictureBox2;
            btn_jugar.Parent = pictureBox2;
            btn_puntajes.Parent = pictureBox2;
            btn_salir.Parent = pictureBox2;
        }

        private void btn_jugar_Click_1(object sender, EventArgs e)
        {
            MenuDosJugadores Menu1 = new MenuDosJugadores();
            this.Visible = false;
            Menu1.ShowDialog();
            this.Visible = true;
        }

        private void btn_puntajes_Click_1(object sender, EventArgs e)
        {
            FormGanadores puntajes = new FormGanadores();
            this.Visible = false;
            puntajes.ShowDialog();
            this.Visible = true;
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btn_puntajes_MouseEnter(object sender, EventArgs e)
        {
            btn_puntajes.ForeColor = Color.FromArgb(230,36,175);
            btn_puntajes.FlatAppearance.BorderSize = 1;
        }

        private void btn_puntajes_MouseLeave(object sender, EventArgs e)
        {
            btn_puntajes.ForeColor = Color.FromArgb(231, 242, 18);
            btn_puntajes.FlatAppearance.BorderSize = 0;
        }

       
        private void btn_salir_MouseEnter(object sender, EventArgs e)
        {
            btn_salir.ForeColor = Color.FromArgb(230, 36, 175);
            btn_salir.FlatAppearance.BorderSize = 1;
        }

        private void btn_salir_MouseLeave(object sender, EventArgs e)
        {
            btn_salir.ForeColor = Color.FromArgb(231, 242, 18);
            btn_salir.FlatAppearance.BorderSize = 0;
        }
    }
}
