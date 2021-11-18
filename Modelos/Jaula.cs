using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modelos
{
    class Jaula
    {

        private int id;
        private string nombre;
        private Espacio espacio;
        private List<Animal> animales;

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
            return true;
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

    }
}
