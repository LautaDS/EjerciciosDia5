using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia5
{
    class Persona
    {
        int edad;
        string nombre;
         public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Persona()
        {
            edad = 1;
        }
        public Persona(int edad)
        {
            this.edad = edad;
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola!");
        }

        public void SetEdad(int edad)
        {
            if (edad > 0)
            { 
            this.edad = edad;
            }
        }




    }
}
