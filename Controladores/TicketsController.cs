using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controladores
{
    public class TicketsController
    {
        public static List<Ticket> listadoTickets()
        {
            return Ticket.all();
        }

        public static bool altaVenta(string documento, string nombre, Ticket ticket)
        {
            Cliente c = Cliente.find(documento);

            if(c == null)
            {
                c = new Cliente();
                c.documento = documento;
                c.nombre = nombre;
                c.save();
            }

            Venta v = new Venta(c, ticket);
            return v.save();
        }

        public static List<Venta> listadoVentas()
        {
            return Venta.all();
        }
    }
}
