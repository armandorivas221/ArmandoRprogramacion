using Armando01.DAO;
using Armando01.NEGOCIO;
using System;

namespace Armando01
{
    internal class ClsLogin
    {
        ClsListaUsuario cls = new ClsListaUsuario();

        


        public int acceso(Login log)
        {
            int estado = 0;
            for (int i=0;i<cls.user.Length;i++) { 
            if (log.Usuario.Equals(cls.user[i]) && log.Password.Equals(cls.password[i])) { 
            
                  estado = 1;
            }
            }

            return estado;
        }


    }     
        
}