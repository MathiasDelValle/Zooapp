using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Usuario
    {
        private int id;
        private string nombre;
        private int nivel;

        public bool controlTotal()
        {
            return this.nivel == -1;
        }


       
    }
}
