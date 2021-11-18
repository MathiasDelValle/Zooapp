using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelos
{
    class Conexion
    {
        //Funcion que oficia para conectarnos a la BD (Se crean variables por mas que tengamos las variables de entorno para dejar la cadena de conexion mas corta)
        private MySqlConnection conectar()
        {
            try
            {
                //Las intente meter en variables de entorno (seria lo mejor) pero no salia y ta, no daban los tiempos.
                string servidor = "127.0.0.1";
                string puerto = "3306";
                string usuario = "root";
                string password = "";
                string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + ";database=controlstock;";

                return new MySqlConnection(cadenaConexion);
            }catch(Exception ex)
            {
                throw new Exception("Error al conectarse a la BD");
            }

        }

        public DataTable queryConsulta(string query)
        {
            try
            {
                MySqlConnection con = this.conectar();
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //MySqlCommand comando = new MySqlCommand(query, con);
                //comando.ExecuteNonQuery();
                return dt;
            }catch(Exception ex)
            {
                //Aca guardaria el log de excepcion para tener mas info y luego la lanzo
                throw new Exception("Error al ejecutar la consulta.");
            }

        }

        public bool queryInsertUpdate(string query)
        {
            try
            {
                MySqlConnection con = this.conectar();
                con.Open();

                MySqlCommand comando = new MySqlCommand(query, con);
                int resultado = comando.ExecuteNonQuery();

                con.Close();

                return resultado > 0;
            }
            catch (Exception ex)
            {
                //Aca guardaria el log de excepcion para tener mas info y luego la lanzo
                throw new Exception("Error al ejecutar la consulta.");
            }
        }


    }
}
