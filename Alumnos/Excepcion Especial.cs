using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
   public class Excepcion_Especial:ApplicationException 
    {
        public Excepcion_Especial()
        {

        }
        public Excepcion_Especial(string msg):base(msg)
        {
                
        }
    }
}
