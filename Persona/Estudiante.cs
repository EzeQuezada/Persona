using System;


namespace Persona
{
    public class Estudiante: Persona
    {
        private string Carrera { get; set; }
        private int Matricula { get; set; }


        public Estudiante(string nombre, string apellido, int edad, string carrera, int matricula)
            : base(nombre, apellido, edad)
        {
          
            this.Carrera = carrera;
            this.Matricula = matricula;
        }

       

        public void MostrarInfoCompleta() 
        {

            MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Matricula: {Matricula}");


        }


    }
}
