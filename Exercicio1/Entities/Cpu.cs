namespace Exercicio1.Entities
{
    class Cpu : Hardware
    {
        public double Clock { get; set; }
        public string Modelo { get; set; }

        public Cpu()
        {
            
        }

        public Cpu(int id, string descricao, double valor, string fabricante, double clock, string modelo)
        :base(id, descricao, valor, fabricante)
        {
            Clock = clock;
            Modelo = modelo;
        }
        
    }
}