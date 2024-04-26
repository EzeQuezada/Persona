using System;

namespace Persona
{
    public abstract class Persona
    {
        

        public string? nombre { get; set; }
      
        public string? apellido { get; set; }

        public abstract int Obteneredad(DateTime fechnac);




    }
   
}
