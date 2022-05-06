using System;

namespace EjerciciosDia5
{
    class EstudianteProfesorTest
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona(20);
            Estudiante estudiante = new Estudiante(20);
            Profesor profesor = new Profesor(33);
            ListGenericPersona<Persona> listaDePersonas = new ListGenericPersona<Persona>();
            persona.Saludar();
            estudiante.Saludar();
            estudiante.VerEdad();
            estudiante.Estudiar();

            profesor.Saludar();
            profesor.Explicar();

            Console.ReadLine();

            listaDePersonas.AddPerson(persona);
            listaDePersonas.AddPerson(profesor);
            listaDePersonas.AddPerson(estudiante);

            if(listaDePersonas.SonTodosMayoresDeEdad())
            {
                Console.WriteLine("Son todos mayores de edad");
            } else
            {
                Console.WriteLine("No todos son mayores de edad");
            }
        }
    }
}
