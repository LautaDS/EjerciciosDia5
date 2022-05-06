using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia5
{
    class Estudiante : Persona
    {
        public Estudiante(int edad) : base(edad)
        {

        }

        public Estudiante(string nombre) : base(nombre)
        {
        }

        public Estudiante(int edad, string nombre) : base(edad, nombre)
        {
        }

        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }

        public void VerEdad()
        {
            Console.WriteLine("Mi edad es: " +Edad);
        }


    }
}
