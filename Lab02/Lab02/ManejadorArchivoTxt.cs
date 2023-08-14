using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Lab02
{
    public class ManejadorArchivoTxt : ManejadorArchivos
    {
        protected string connectionString {
            get {
                return @"Provider=Microsoft.Jet.OLEDB.4.0;
                Data Source=C:\Proyectos\Unidades\Unidad 04\Lab02\Lab02\bin\Debug;" +
                "Extended Properties='text;HDR=Yes;FMT=Delimited'";

            }



        }

        public override DataTable getTabla()
        {
            using (OleDbConnection Conn = new OleDbConnection(connectionString))
            {
                OleDbcommand cmdSelect = new OleDbcommand("select * from agenda.txt", Conn);

            }

        }
    }
}
