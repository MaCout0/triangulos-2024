namespace Triangulos.ConsoleApp
{
    public class Triangulo
    {
        //atributos
        public decimal x;
        public decimal y;
        public decimal z;
        public int count = 0;

        public void VerificaTriangulo()
        {
            decimal[] somaLados = new decimal[3];
            somaLados[0] = x + y;
            somaLados[1] = y + z;
            somaLados[2] = x + z;


            for (int i = 0; i < somaLados.Length; i++)
            {
                if (somaLados[i] > x)
                {
                    count++;
                }
            }
            for (int i = 0; i < somaLados.Length; i++)
            {
                if (somaLados[i] > y)
                {
                    count++;
                }
            }
            for (int i = 0; i < somaLados.Length; i++)
            {
                if (somaLados[i] > z)
                {
                    count++;
                }
            }
        }

        public void ClassificaTriangulo()
        {
            if (count != 9)
            {
                Console.WriteLine("Os valores não compõe um triangulo.");
            }
            else
            {
                //classificando o triangulo
                if (x == y && y == z)
                {
                    Console.Clear();
                    Console.WriteLine("Este triangulo é equilatero");
                }
                else if (x == y && y != z)
                {
                    Console.Clear();
                    Console.WriteLine("Esse triangulo é isósceles");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Esse triangulo é escaleno");
                }
            }

            Console.ReadLine();
        }
    }
}
