using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modelos
{
    class Animal
    {
        private int id;
        private string nombre;
        private Jaula jaula;

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

        public int Id()
        {
            return this.id;
        }

        public string Nombre()
        {
            return this.nombre;
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
            return true;
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

    }
}
