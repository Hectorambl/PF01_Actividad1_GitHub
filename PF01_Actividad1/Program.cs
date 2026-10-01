namespace PF01_Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan", 25);
            persona1.MostrarDatos();

            persona1.MdificarNombre("Carlos");
            persona1.MostrarDatos();
        }
    }
}
