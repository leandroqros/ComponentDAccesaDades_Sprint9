using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Funcciones
{
    class Funciones
    {
        //Variables universales
        SqlConnection conect;
        SqlDataAdapter tablaTemporal;
        DataSet dts = new DataSet();

        //Funcion de Conectar
        public void Connectar()
        {
            string connectionString = "Data Source=CAFUNEPORTATIL\\SQLEXPRESS;Initial Catalog=Species;Integrated Security=True";
            conect = new SqlConnection(connectionString);
            conect.Open();
        }

        public DataSet PortarTaula(string nombreTabla)
        {
            string query;
            query = "select * from *";
            tablaTemporal = new SqlDataAdapter(query, conect);

            tablaTemporal.Fill(dts, nombreTabla);
            return dts;
        }

        public DataSet portarPerConsulta(string query)
        {
            string consulta;
            consulta = query;
            tablaTemporal = new SqlDataAdapter(query, conect);

            tablaTemporal.Fill(dts);
            return dts;
        }

        public DataSet portarPerConsulta(string query, string nomTabla)
        {
            string consulta;
            consulta = query;
            tablaTemporal = new SqlDataAdapter(query, conect);

            tablaTemporal.Fill(dts, nomTabla);
            return dts;
        }

        public void Actualizar(string consulta, DataSet data)
        {

        }

    }
}
