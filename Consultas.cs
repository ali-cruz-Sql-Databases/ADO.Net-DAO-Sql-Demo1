using SqlConnectionClassTest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnectionClassTest
{
    public class Consultas
    {
        public RespuestaDataTable ConsultaPeople()
        {
            DAOConsulta consulta = new DAOConsulta();

            RespuestaDataTable response = new RespuestaDataTable();
            
            string q = "EXECUTE spSelectAllPeople";
            response = consulta.Consulta(q);
            return response;
        }
    }
}
