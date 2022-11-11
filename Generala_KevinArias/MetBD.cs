using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Variables;
using System.Data.OleDb;

namespace MetodosBD
{
    public class MetBD
    {
        public static OleDbConnection conexionConBd;
        public static string strconexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=DbGenerala2.mdb;";
        public static OleDbCommand orden;
        public static OleDbCommand lector;

        public OleDbDataReader Leer(string consulta)
        {
            conexionConBd = new OleDbConnection(strconexion);
            orden = new OleDbCommand(consulta, conexionConBd);

            try
            {
                conexionConBd.Open();
                return orden.ExecuteReader();
            }
            catch
            {
                OleDbDataReader error = null;
                return error;
            }
        }

        public bool ABM(string consulta)
        {
            bool resultado = false;

            conexionConBd = new OleDbConnection(strconexion);
            orden = new OleDbCommand(consulta, conexionConBd);

            try
            {
                conexionConBd.Open();
                orden.ExecuteNonQuery();
                resultado = true;
            }
            catch
            {
                resultado = false;
            }

            Desconectar();
            return resultado;
        }

        public void Desconectar()
        {
            if (conexionConBd.State == System.Data.ConnectionState.Open)
                conexionConBd.Close();
        }

    }
}
