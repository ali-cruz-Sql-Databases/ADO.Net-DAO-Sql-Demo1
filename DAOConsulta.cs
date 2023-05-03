using SqlConnectionClassTest.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnectionClassTest
{
    public class DAOConsulta
    {
        private string stringConn = ConfigurationManager.ConnectionStrings["DBSample"].ConnectionString;

        public RespuestaDataTable Consulta(string q)
        {
            RespuestaDataTable respuesta = new RespuestaDataTable();
            respuesta.dt = new DataTable();

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(stringConn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(q, sqlConn);
                    sqlConn.Open();
                    da.Fill(respuesta.dt);
                    sqlConn.Close();
                    
                    return respuesta;                    
                }
            } catch (SqlException sqlE)
            {
                respuesta.Msg = sqlE.Message;
                return respuesta;
            }
        }
    }
}
