namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digíte a quantidade de posições: ");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];
            // Digitar um número ao lado do outro com espaço
            Console.Write("Digíte os " + n + " valores inteiros do vetor: ");
            string[] x = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < n; i++)
            {
                vetor[i] = int.Parse(x[i]);
            }

            int pares = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    pares++;
                }
            }
            Console.WriteLine("Quantidade de numeros pares: " + pares);
            int impares = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 1)
                {
                    impares++;
                }
            }
            Console.WriteLine("Quantidade de numeros impares: " + impares);

            string repetidos = "";
            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (vetor[i] == vetor[j])
                    {
                        repetidos = repetidos + vetor[i]+" ";
                        count++;
                    }
                }
            }

            Console.WriteLine("Quantidade de números repitidos: "+count);
            Console.WriteLine("Esses número se repetiram: "+repetidos);
        }
    }
}