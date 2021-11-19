using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controladores
{
    public class EspaciosController
    {

        public static bool altaEspacio(string nombre)
        {
            if (Espacio.exist(nombre))
            {
                throw new Exception("El nombre de espacio ya esta siendo utilizado");
            }

            Espacio e = new Espacio(nombre);
            return e.save();
        }
    }
}
