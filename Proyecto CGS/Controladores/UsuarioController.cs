using Proyecto_CGS.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CGS.Controladores
{
    internal class UsuarioController
    {
        ModelVentaDeComputadoras _context = new ModelVentaDeComputadoras();
        public bool Login(string usuario, string password)
        {
            var UsuarioLogin = _context.Usuario.Where(x => x.NombreUsuario == usuario 
                                                    && x.PasswordUsuario == password).SingleOrDefault();
            if (UsuarioLogin != null) 
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}
