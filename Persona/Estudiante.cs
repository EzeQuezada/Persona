using System;


namespace Persona
{
    public class Estudiante: Persona
    {
        private string? Carrera { get; set; }
        private string? Matricula { get; set; }



       

       

        public override int Obteneredad(DateTime fechnac)
        {
            var edad = DateTime.Now.Year - fechnac.Year;


            return edad;
        }
        public void MostrarInfoCompleta()
        {


            Console.WriteLine($"Nombre:Ezequiel {nombre}");
            Console.WriteLine($"Apellido:Quezada {apellido}");
            Console.WriteLine($"Carrera: Software {Carrera}");
            Console.WriteLine($"Matricula: 2023-1021 {Matricula}");
            Console.WriteLine($"Edad: 20 años");
        }
    }
}
