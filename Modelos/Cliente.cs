using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modelos
{
    public class Cliente
    {
        public string nombre;
        public string documento;

        public bool save()
        {
            string sql = "INSERT INTO clientes (nombre, documento) VALUES ('" + this.nombre + "', '" + this.documento + "');";

            Conexion con = new Conexion();
            return con.queryInsertUpdate(sql);
        }


        public static Cliente find(string documento)
        {
            Conexion con = new Conexion();
            DataTable resultado = con.queryConsulta("SELECT * FROM clientes where documento = '" + documento + "' LIMIT 1");
            if (resultado.Rows.Count == 0)
            {
                return null;
            }

            Cliente a = new Cliente();
            a.nombre = (string)resultado.Rows[0]["nombre"];
            a.documento = (string)resultado.Rows[0]["documento"];
            return a;
        }

    }
}
