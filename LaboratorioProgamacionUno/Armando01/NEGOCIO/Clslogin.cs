using System;
using System.Collections.Generic;
using System.Text;

namespace Armando01.NEGOCIO
{
    class Clslogin
    {
        

        public int Acceso(Login log)
        {
            int estado = 1;
            if (log.Usuario.Equals("armando")&& log.Password.Equals("1234")) {
                estado = 1;
            }

            return estado;


        
        }
         

        
        

            
        
    }
}
