using Exercicio4.Entities;
using Exercicio4.Services;
namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            IAcoesAnimais cachorro = new Cachorro() {Classe = "Mamífero", Alimentacao = "Carnívoro", Habitat = "Terrestre"};
            IAcoesAnimais aguia = new Aguia() {Classe = "Aves", Alimentacao = "Carnívoro", Habitat = "Aéreo"};
            IAcoesAnimais lagarto = new Lagarto() {Classe = "Répteis", Alimentacao = "Onívoro", Habitat = "multi habitat"};

            Console.WriteLine(cachorro);
            Console.WriteLine(aguia);
            Console.WriteLine(lagarto);

           

        }
    }
}
