namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digíte a quantidade de posições: ");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

            Console.Write("Digíte os " + n + " valores inteiros do vetor: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                vetor[i] = n;
            }

            //numeros pares
            int pares = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    pares++;
                }
            }
            Console.WriteLine("Quantidade de numeros pares: " + pares);

            //numeros impares
            int impares = n - pares;
            Console.WriteLine("Quantidade de numeros impares: " + impares);

            //Quantidade de números repetidos
            //encontra o maior e o menor numero do vetor
            int maior = vetor[0];
            for (int i = 0; i < vetor.Length; i++)
            {
                if (maior < vetor[i+1])
                {
                    maior = vetor[i+1];
                }
            }

            int menor = vetor[0];
            for (int i = 0; i < vetor.Length; i++)
            {
                if (menor > vetor[i+1])
                {
                    menor = vetor[i+1];
                }
            }

            //confere se existe algum repetido entre todos os numeros entre o maior e o menor
           int[] repetidos = new int[vetor.Length];
            for (int i = menor; i <= maior; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (vetor[j] == vetor[i])
                    {
                        count++;
                        if (!(vetor[j] == vetor[i]))
                        {
                            vetor[i] = vetor[j];
                        }
                    }
                }
            }
            
            Console.WriteLine("Os numeros repetidos são: ");
            for (int i = 0; i < repetidos.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}