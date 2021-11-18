using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Animal : Model<Animal>
    {

        public bool save()
        {
            return true;
        }

        public Animal find(int id)
        {
            return this;
        }
    }
}
