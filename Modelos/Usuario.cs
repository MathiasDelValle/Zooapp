using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modelos
{
    public class Usuario
    {
        public int id;
        public string nombre;
        public string pass;
        public int nivel;

        public bool controlTotal()
        {
            return this.nivel == -1;
        }


        public static Usuario where(string columna, string comparador, string valor, int cantidad = 1)
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM usuarios WHERE " + columna + " " + comparador + " '" + valor + "' LIMIT " + cantidad;
            DataTable dt = con.queryConsulta(sql);

            if(dt.Rows.Count == 0)
            {
                return null;
            }

            Usuario u = new Usuario();
            u.id = (int)dt.Rows[0]["id"];
            u.nombre = dt.Rows[0]["nombre"].ToString();
            u.pass = dt.Rows[0]["pass"].ToString();
            u.nivel = (int)dt.Rows[0]["nivel"];

            return u;
        }


       
    }
}
