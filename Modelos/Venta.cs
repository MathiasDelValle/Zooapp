using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modelos
{
    public class Venta
    {

        public Cliente cliente;
        public Ticket ticket;

        public Venta(string documento, int idTicket)
        {
            this.cliente = Cliente.find(documento);
            this.ticket = Ticket.find(idTicket);
        }

        public Venta(Cliente c, Ticket t)
        {
            this.cliente = c;
            this.ticket = t;
        }

        public bool save()
        {
            string sql = "INSERT INTO ventas (documento, ticket_id) VALUES ('" + this.cliente.documento + "', " +  this.ticket.Id + ");";

            Conexion con = new Conexion();
            return con.queryInsertUpdate(sql);
        }

        public static List<Venta> all(bool activos = true)
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM ventas";

            DataTable dt = con.queryConsulta(sql);

            List<Venta> ventas = new List<Venta>();

            foreach (DataRow row in dt.Rows)
            {
                ventas.Add(new Venta(row["documento"].ToString(), (int)row["ticket_id"]));
            }

            return ventas;
        }

    }
}
