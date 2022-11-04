using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BiblioteclaDeClases
{
    public class Class1
    {
        //Variables universales
        SqlConnection conect;
        string connectionString = "Data Source=CAFUNEPORTATIL\\SQLEXPRESS;Initial Catalog=Species;Integrated Security=True";
        string query = "select * from Species";

        SqlDataAdapter tablaTemporal;
        DataSet dts = new DataSet();

        //Funcion de Conectar
        public void Connectar()
        {
           conect = new SqlConnection(connectionString);
        }

        public DataSet PortarTaula(string nombreTabla)
        {
            tablaTemporal = new SqlDataAdapter(query, conect);
            conect.Open();

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
            //crea Adapter para actualziar la tabla
            SqlDataAdapter actualizar;
            actualizar = new SqlDataAdapter(consulta, conect);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new
            SqlCommandBuilder(actualizar);

            if (dts.HasChanges())
            {
                int result = actualizar.Update(dts.Tables[0]);
            }
        }

        public void Executa(string consulta)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conect);
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(adapter);

            //if (LAS LINEAS DENTRO DEL if VAN AL FORMULARIO)
            //{
            //    //DataRow dr = dts.Tables[0].NewRow();
            //    //dr[0] = txtCode.Text;
            //    //dr[0] = txtEspecie.Text;

            //    //dts.Tables[0].Rows.Add(dr);
            //}

            if (dts.HasChanges())
            {
                int result = tablaTemporal.Update(dts.Tables[0]);
            }
        }
        

        //private void bntmaxi()
        //{
        //    private void SQLUpdate()
        //    {
        //        conn.Open();

        //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //        SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);

        //        if (isNew)
        //        {
        //            DataRow dr = dts.Tables[0].NewRow();

        //            dr["CodeSpecie"] = TBCode.Text;
        //            dr["DescSpecie"] = TBDesc.Text;

        //            dts.Tables[0].Rows.Add(dr);
        //        }

        //        if (dts.HasChanges())
        //        {
        //            int result = adapter.Update(dts.Tables[0]);
        //            adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

        //            string recordCount;

        //            if (result == 1)
        //            {
        //                recordCount = "record was";
        //            }
        //            else
        //            {
        //                recordCount = "records were";
        //            }
        //            MessageBox.Show($"{result} {recordCount} modified.");

        //            isNew = false;
        //            ((DataTable)DGVSpecies.DataSource).Rows.Clear();
        //            BTNUpdate.Validated += new System.EventHandler(this.Form1_Load);
        //        }

        //        conn.Close();

        //        SQLAddData(@"Data Source=MAXI-XPS13\SQLEXPRESS;Initial Catalog=SecureCore;Integrated Security=True", "Species");
        //    }

        //    private void OnRowUpdated(object sender, SqlRowUpdatedEventArgs args)
        //    {
        //        if (args.Status == UpdateStatus.ErrorsOccurred)
        //        {
        //            MessageBox.Show(args.Errors.Message);
        //            args.Status = UpdateStatus.SkipCurrentRow;
        //        }
        //    }
        //}
    }
}
