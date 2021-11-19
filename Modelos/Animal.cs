using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modelos
{
    public class Animal
    {
        private int id;
        private string nombre;
        private Jaula jaula;
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Animal()
        {

        }

        public Animal(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Animal(int id, string nombre, Jaula jaula)
        {
            this.id = id;
            this.nombre = nombre;
            this.jaula = jaula;
        }

        public Animal(int id, string nombre, int idJaula)
        {
            this.id = id;
            this.nombre = nombre;
            this.jaula = Jaula.find(idJaula);
        }

        public Jaula getJaula()
        {
            return this.jaula;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setJaula(Jaula jaula)
        {
            this.jaula = jaula;
        }

        public bool save()
        {
            string sql = "INSERT INTO animales (nombre, jaula_id) VALUES ('" + this.nombre + "', " + this.jaula.Id + ");";

            if(this.id > 0)
            {
                sql = "UPDATE animales SET nombre = '" + this.nombre + "', jaula_id = " + this.jaula.Id + " WHERE id = " + this.id + ";";
            }

            Conexion con = new Conexion();
            return con.queryInsertUpdate(sql);
        }

        public bool delete()
        {
            string sql = "UPDATE animales SET deleted_at = NOW() WHERE id = " + this.id + ";";
            Conexion con = new Conexion();
            return con.queryInsertUpdate(sql);
        }

        public static Animal find(int id)
        {
            Conexion con = new Conexion();
            DataTable resultado = con.queryConsulta("SELECT * FROM animales where id = " + id + " LIMIT 1");
            if(resultado == null)
            {
                return null;
            }

            Animal a = new Animal();
            a.setNombre((string)resultado.Rows[0]["nombre"]);
            Jaula jaula = new Jaula();
            a.setJaula(Jaula.find((int)resultado.Rows[0]["jaula_id"]));

            return a;
        }

        public static List<Animal> all(bool activos = true)
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM animales";
            if (activos)
            {
                sql += " WHERE deleted_at IS NULL";
            }

            DataTable dt = con.queryConsulta(sql);

            List<Animal> animales = new List<Animal>();
   
            foreach (DataRow row in dt.Rows)
            {
                int idAnimal = (int)row["id"];
                string nombreAnimal = row["nombre"].ToString();
                int idJaula = (int)row["jaula_id"];

                animales.Add(new Animal(idAnimal, nombreAnimal, idJaula));
            }

            return animales;
        }
    }
}
