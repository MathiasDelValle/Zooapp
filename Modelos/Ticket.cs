using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modelos
{
    class Ticket
    {
        private int id;
        private string nombre;
        private decimal valor;
        private List<Espacio> espacios;

        public int Id()
        {
            return this.id;
        }

        public string Nombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }


        public List<Espacio> getEspacios()
        {
            if (this.espacios == null)
            {
                // obtengo el listado
            }

            return this.espacios;
        }

        public bool save()
        {
            return true;
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
            return a;
        }

    }
}
