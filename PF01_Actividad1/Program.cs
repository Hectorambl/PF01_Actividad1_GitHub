namespace PF01_Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona pers = new Persona("Marcos", 22);
            pers.MostrarDatos();

            pers.ModificarNombre("Carlos");
            pers.MostrarDatos();
        }
    }
}
