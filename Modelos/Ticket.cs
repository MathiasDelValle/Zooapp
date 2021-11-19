using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modelos
{
    public class Ticket
    {
        private int id;
        private string nombre;
        private decimal valor;
        private int espacios;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public int Espacios { get => espacios; set => espacios = value; }


        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

    

        public bool save()
        {
            return true;
        }

        public Ticket()
        {

        }


        public static Ticket find(int id)
        {
            Conexion con = new Conexion();
            DataTable resultado = con.queryConsulta("SELECT * FROM tickets where id = " + id + " LIMIT 1");
            if (resultado == null)
            {
                return null;
            }

            Ticket a = new Ticket();
            a.id = id;
            a.setNombre((string)resultado.Rows[0]["nombre"]);
            a.valor = (decimal)resultado.Rows[0]["valor"];
            a.espacios = (int)resultado.Rows[0]["cantidad_espacios"];
            return a;
        }

        public static List<Ticket> all(bool activos = true)
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM tickets";
            if (activos)
            {
                sql += " WHERE deleted_at IS NULL";
            }

            DataTable dt = con.queryConsulta(sql);

            List<Ticket> tickets = new List<Ticket>();

            foreach (DataRow row in dt.Rows)
            {
                Ticket t = new Ticket();
                t.id = (int)row["id"];
                t.nombre = row["nombre"].ToString();
                t.valor = (decimal)row["valor"];
                t.espacios = (int)row["cantidad_espacios"];

                tickets.Add(t);
            }

            return tickets;
        }

    }
}
