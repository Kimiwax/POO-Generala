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
    public partial class ShowDialogGanaste : Form
    {
        
        public ShowDialogGanaste(string ganador)
        {
            InitializeComponent();
            lbl_nombre.Parent = picB_Ganaste;
            lbl_ganaste.Parent = picB_Ganaste;
            btn_ok.Parent = picB_Ganaste;
            lbl_nombre.Text = ganador;
        }

        

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_ok_MouseEnter(object sender, EventArgs e)
        {
            btn_ok.ForeColor = Color.FromArgb(231, 242, 18);
            btn_ok.FlatAppearance.BorderSize = 1;
        }

        private void btn_ok_MouseLeave(object sender, EventArgs e)
        {
            btn_ok.ForeColor = Color.FromArgb(231, 242, 18);
            btn_ok.FlatAppearance.BorderSize = 0;
        }
    }
}
