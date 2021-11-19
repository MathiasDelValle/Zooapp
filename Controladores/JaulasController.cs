using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controladores
{
    public class JaulasController
    {
        public static List<Espacio> vistaAltaJaulas()
        {
            return Espacio.all();
        }

        public static List<Jaula> listadoJaulas()
        {
            return Jaula.all();
        }

        public static bool altaJaula(string nombreJaula, int idEspacio)
        {
            try
            {
                if (nombreJaula == "" || idEspacio < 0)
                {
                    return false;
                }

                Jaula a = new Jaula();
                a.setNombre(nombreJaula);
                a.setEspacio(Espacio.find(idEspacio));
                return a.save();
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static bool modificarJaula(int idJaula, string nombreJaula, int idEspacio)
        {
            try
            {
                if (idJaula <= 0 || nombreJaula == "" || idEspacio <= 0)
                {
                    return false;
                }

                Jaula a = new Jaula(idJaula, nombreJaula, idEspacio);
                return a.save();

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool eliminarJaula(int idJaula)
        {
            try
            {
                Jaula a = Jaula.find(idJaula);
                return a.delete();
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
