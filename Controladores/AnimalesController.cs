using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controladores
{
    public class AnimalesController
    { 

        public static List<Jaula> vistaAltasAnimales()
        {
            return Jaula.all();
        }

        public static List<Animal> listadoAnimales()
        {
            return Animal.all();
        }

        public static bool altaAnimal(string nombreAnimal, int idJaula)
        {
            try
            {
                if (nombreAnimal == "" || idJaula < 0)
                {
                    return false;
                }

                Animal a = new Animal();
                a.setNombre(nombreAnimal);
                a.setJaula(Jaula.find(idJaula));
                return a.save();
            }catch(Exception ex)
            {
                return false;
            }

        }

        public static bool modificarAnimal(int idAnimal, string nombreAnimal, int idJaula)
        {
            try
            {
                if(idAnimal <= 0 || nombreAnimal == "" || idJaula <= 0)
                {
                    return false;
                }

                Animal a = new Animal(idAnimal, nombreAnimal, idJaula);
                return a.save();

            }catch(Exception ex)
            {
                return false;
            }
        }

        public static bool eliminarAnimal(int idAnimal)
        {
            try
            {
                Animal a = Animal.find(idAnimal);
                return a.delete();
            }catch(Exception ex){
                return false;
            }
            
        }
    }
}
