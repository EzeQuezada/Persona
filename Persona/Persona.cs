using System;

namespace Persona
{
    public abstract class Persona
    {
        protected Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public string? nombre { get; set; }
        public int edad { get; set; }
        public string? apellido { get; set; }

        public void PersonaInfo(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.apellido = apellido; 
        }
        public void MostrarInformacion() 
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellido: {apellido}");
            Console.WriteLine($"Edad: {edad} años");
        }

        public int Calcularaños(int añoactual) 
        {
            int añoDeNacimiento = añoactual - edad;

            return añoDeNacimiento;
        }
    }
   
}
