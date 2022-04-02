using Exercicio1.Entities;
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hardware> list = new List<Hardware>();

            list.Add(new Cpu(123, "Processador AMD", 2150.0, "AMD", "3.7", "Ryzen 7"));
            list.Add(new Memoria(124, "Memoria RAM", 240.50, "Corser", "3200", "8GB", "DDR4"));
            list.Add(new DiscoRigido(125, "HDD Seagate", 540.45, "Seagate", "500", "7200", "HDD"));

            foreach (Hardware item in list)
            {
                Console.WriteLine(item.DetalhesHardware());
            }
        }
    }
}
