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


        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }

        public void ModificarNombre(string nombre)
        {
            Nombre = nombre;
        }

        public bool ComprobarEdad(int per)
        {
            if (per >= 18)
                return true;
            return false;
        }
    }
}
