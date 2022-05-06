using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia5
{
    class ListGenericPersona <T> where T : Persona
    {
        List<T> lista = new List<T>();
     

        public void AddPerson (T person)
        {
            lista.Add(person);
        }

        public bool SonTodosMayoresDeEdad()
        {
            bool flagMenores = false;
            int contadorMenores = 0;
            if (lista.Count > 0)
            {
                foreach (T person in lista)
                {

                    if(person.Edad < 18)
                    {
                        contadorMenores++;
                    } 
                }
            }
          if(contadorMenores > 0)
            {
                return false;

            }else
            {
                return true;
            }
        }
    }
}
