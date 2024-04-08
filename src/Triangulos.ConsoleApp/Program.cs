namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar variavel de classe
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Passe os valores do triangulo: ");
            Console.Write("X = ");
            triangulo.x = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Y = ");
            triangulo.y = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Z = ");
            triangulo.z = Convert.ToDecimal(Console.ReadLine());

            triangulo.VerificaTriangulo();

            triangulo.ClassificaTriangulo();

            Console.ReadLine ();
        }
    }
}
