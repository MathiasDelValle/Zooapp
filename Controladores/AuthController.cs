using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controladores
{
    public class AuthController  
    {
        private Usuario usuLogin;

        private bool validacion(string usu, string pass)
        {
            try
            {
                if (String.IsNullOrEmpty(usu) || String.IsNullOrEmpty(pass))
                {
                    return false;
                }

                Usuario u = Usuario.where("nombre", "=", usu);

                if (u == null)
                {
                    return false;
                }

                this.usuLogin = u;

                if (u.pass == pass)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la validacion de cuenta");
            }
        }


        public Usuario login(string usuario, string pass)
        {
            try
            {
                if (!validacion(usuario, pass))
                {
                    throw new Exception("Usuario no encontrado.");
                }
                else
                {
                    return this.usuLogin;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Usuario no obtenido.");
            }
        }
    }
}
