using System;
using System.Collections.Generic;
using System.Text;

namespace PF01_Actividad1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }


        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

    }
}
