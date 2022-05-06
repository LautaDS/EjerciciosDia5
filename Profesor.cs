using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia5
{
    class Profesor : Persona
    {
        public Profesor()
        {
        }

        public Profesor(int edad) : base(edad)
        {

        }

        public Profesor(string nombre) : base(nombre)
        {
        }

        public Profesor(int edad, string nombre) : base(edad, nombre)
        {
        }

        public void Explicar()
        {
            Console.WriteLine("Estoy explicando");
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
