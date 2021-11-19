using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modelos
{
    public class Jaula
    {

        public int id;
        public string nombre;
        public Espacio espacio;
        private List<Animal> animales;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Jaula()
        {

        }

        public Jaula(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Jaula(int id, string nombre, Espacio espacio)
        {
            this.id = id;
            this.nombre = nombre;
            this.espacio = espacio;
        }

        public Jaula(int id, string nombre, int idEspacio)
        {
            this.id = id;
            this.nombre = nombre;
            this.espacio = Espacio.find(idEspacio);
        }


        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public Espacio getEspacio()
        {
            return this.espacio;
        }

        public void setEspacio(Espacio espacio)
        {
            if(this.espacio == null)
            {
                //obtengo el espacio
            }
            this.espacio = espacio;
        }

        public List<Animal> getListaAnimales()
        {
            if(this.animales == null)
            {
                Conexion con = new Conexion();
                DataTable resultado = con.queryConsulta("SELECT * FROM animales where jaula_id = " + this.id);
                this.animales = new List<Animal>();
                foreach (DataRow row in resultado.Rows)
                {
                    int id          = (int)row["id"];
                    string nombre   = row["nombre"].ToString();
                    int idJaula     = (int)row["jaula_id"];

                    this.animales.Add(new Animal(id, nombre, idJaula));
                }
            }

            return this.animales;
        }

        public bool save()
        {
            string sql = "INSERT INTO jaulas (nombre, espacio_id) VALUES ('" + this.nombre + "', " + this.espacio.Id + ");";

            if (this.id > 0)
            {
                sql = "UPDATE jaulas SET nombre = '" + this.nombre + "', jaula_id = " + this.espacio.Id + " WHERE id = " + this.id + ";";
            }

            Conexion con = new Conexion();
            return con.queryInsertUpdate(sql);
        }

        public bool delete()
        {
            string sql = "UPDATE jaulas SET deleted_at = NOW() WHERE id = " + this.Id;
            Conexion con = new Conexion();
            return con.queryInsertUpdate(sql);
        }

        public static Jaula find(int id)
        {
            Conexion con = new Conexion();
            DataTable resultado = con.queryConsulta("SELECT * FROM jaulas where id = " + id + " LIMIT 1");
            if (resultado == null)
            {
                return null;
            }

            Jaula a = new Jaula();
            a.id = (int)resultado.Rows[0]["id"];
            a.setNombre((string)resultado.Rows[0]["nombre"]);
            Espacio jaula = new Espacio();
            a.setEspacio(Espacio.find((int)resultado.Rows[0]["espacio_id"]));

            return a;
        }

        public static List<Jaula> all(bool activos = true)
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM jaulas";
            if (activos)
            {
                sql += " WHERE deleted_at IS NULL";
            }

            DataTable dt = con.queryConsulta(sql);

            List<Jaula> jaulas = new List<Jaula>();

            foreach (DataRow row in dt.Rows)
            {
                int idJaula = (int)row["id"];
                string jaula = row["nombre"].ToString();
                int idEspacio = (int)row["espacio_id"];

                jaulas.Add(new Jaula(idJaula, jaula, idEspacio));
            }

            return jaulas;
        }

        override
        public string ToString()
        {
            return this.nombre;
        }

    }
}
