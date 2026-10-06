namespace PF01_Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Persona persona1 = new Persona("Juan", 25);
            persona1.MostrarDatos();

            persona1.MdificarNombre("Carlos");
            persona1.MostrarDatos();
=======
            Persona pers = new Persona("Marcos", 22);
            pers.MostrarDatos();

            pers.MostrarDatos();

            bool p = pers.ComprobarEdad(pers.Edad);
>>>>>>> origin/Func2_dev2
        }
    }
}
