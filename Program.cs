using System;

namespace App15
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, M, A, B, X;
            string inputData = Console.ReadLine(); // citim primul număr
            N = int.Parse(inputData);
            inputData = Console.ReadLine(); // citim al doilea număr
            M = int.Parse(inputData);
            inputData = Console.ReadLine(); // citim al treilea număr
            A = int.Parse(inputData);
            inputData = Console.ReadLine(); // citim al patrulea număr
            B = int.Parse(inputData);


            X = Math.Ceiling(((N * M) + (15 * (N * M))/100) / (A * B));

            Console.WriteLine(X);
        }
    }
}
