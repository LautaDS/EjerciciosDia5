using System;

namespace EjerciciosDia5
{
    class EstudianteProfesorTest
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Estudiante estudiante = new Estudiante(18);
            Profesor profesor = new Profesor(33);

            persona.Saludar();
            estudiante.Saludar();
            estudiante.VerEdad();
            estudiante.Estudiar();

            profesor.Saludar();
            profesor.Explicar();

            Console.ReadLine();
        }
    }
}
