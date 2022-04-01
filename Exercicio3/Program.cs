using Exercicio3.Entities;
using System.Globalization;
namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra sua expectativa de vida: ");
            Console.Write("informe o nome: ");
            string nome = Console.ReadLine();
            Console.Write("informe o sexo: ");
            string sexo = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            DateTime dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - dataNascimento.Year;
            Pessoa pessoa = new Pessoa(nome, sexo, dataNascimento);
            Console.WriteLine();
            Console.WriteLine("Levando em consideração sua idade atual: "+idade);
            Console.WriteLine(pessoa);
        }
    }
}
