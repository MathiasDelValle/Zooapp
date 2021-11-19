using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modelos
{
    public class Espacio
    {

        private int id;
        private string nombre;
        private List<Jaula> jaulas;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Espacio()
        {
        }

        public Espacio(string nombre)
        {
            this.nombre = nombre;
        }

        public Espacio(int idEspacio, string nombre)
        {
            this.id = idEspacio;
            this.nombre = nombre;
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
            string sql = "INSERT INTO espacios (nombre) VALUES ('" + this.nombre + "');";

            if (this.id > 0)
            {
                sql = "UPDATE espacios SET nombre = '" + this.nombre + "' WHERE id = " + this.id + ";";
            }

            Conexion con = new Conexion();
            return con.queryInsertUpdate(sql);
        }

        public bool delete()
        {
            string sql = "UPDATE espacios SET deleted_at = NOW() WHERE id = " + this.Id;
            Conexion con = new Conexion();
            return con.queryInsertUpdate(sql);
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

        public static List<Espacio> all(bool activos = true)
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM espacios";
            if (activos)
            {
                sql += " WHERE deleted_at IS NULL";
            }

            DataTable dt = con.queryConsulta(sql);

            List<Espacio> espacios = new List<Espacio>();

            foreach (DataRow row in dt.Rows)
            {
                int idEspacio = (int)row["id"];
                string nombre = row["nombre"].ToString();

                espacios.Add(new Espacio(idEspacio, nombre));
            }

            return espacios;
        }

        public static bool exist(string nombre)
        {
            Conexion con = new Conexion();
            DataTable resultado = con.queryConsulta("SELECT id FROM espacios where nombre = '" + nombre + "'");

            return resultado.Rows.Count > 0;
        }
    }
}
