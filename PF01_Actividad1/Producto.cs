using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PF01_Actividad1
{
    public class Producto
    {
        public string NombreProd { get; set; }
        public int Precio { get; set; }

        public Producto(string nombre, int precio)
        {
            NombreProd = nombre;
            Precio = precio;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {NombreProd}, Edad: {Precio}");
        }
    }
}
