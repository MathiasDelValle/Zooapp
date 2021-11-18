using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modelos
{
    class Espacio
    {

        private int id;
        private string nombre;
        private List<Jaula> jaulas;

        public string Nombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }


        public List<Jaula> getListaJaulas()
        {
            if (this.jaulas == null)
            {
                Conexion con = new Conexion();
                DataTable resultado = con.queryConsulta("SELECT * FROM animales where jaula_id = " + this.id);
                this.jaulas = new List<Jaula>();
                foreach (DataRow row in resultado.Rows)
                {
                    int id = (int)row["id"];
                    string nombre = row["nombre"].ToString();
                    int idJaula = (int)row["jaula_id"];

                    this.jaulas.Add(new Jaula(id, nombre, idJaula));
                }
            }

            return this.jaulas;
        }

        public bool save()
        {
            return true;
        }

        public static Espacio find(int id)
        {
            Conexion con = new Conexion();
            DataTable resultado = con.queryConsulta("SELECT * FROM espacios where id = " + id + " LIMIT 1");
            if (resultado == null)
            {
                return null;
            }

            Espacio a = new Espacio();
            a.id = id;
            a.setNombre((string)resultado.Rows[0]["nombre"]);

            return a;
        }
    }
}
