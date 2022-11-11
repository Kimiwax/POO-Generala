using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Variables;
using Metodos;
using MetodosBD;
using System.Data.OleDb;

namespace Generala_KevinArias
{
    public partial class FormGanadores : Form
    {
        public FormGanadores()
        {
            InitializeComponent();
            
        }
        DataTable tabla = new DataTable();
        MetBD MetodoDB = new MetBD();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGanadores_Load(object sender, EventArgs e)
        {
            tabla.Clear();
            tabla.Load(MetodoDB.Leer("SELECT * FROM Puntaje"));
            dgv_ganadores.DataSource = tabla;
            MetodoDB.Desconectar();

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
    }
}
