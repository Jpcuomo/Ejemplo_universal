using ClassLibrary1;

namespace El_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Juan", "Cuomo", "114485");
            estudiante1.SetNotaPrimerParcial = 10;
            estudiante1.SetNotaSegundoParcial = 10;
            
            Estudiante estudiante2 = new Estudiante("Luca", "Cuomo", "114486");
            estudiante2.SetNotaPrimerParcial = 8;
            estudiante2.SetNotaSegundoParcial = 7;

            Estudiante estudiante3 = new Estudiante("Lucía", "Román", "114481");
            estudiante3.SetNotaPrimerParcial = 2;
            estudiante3.SetNotaSegundoParcial = 4;

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}