namespace Exercicio1.Entities
{
    class DiscoRigido : Hardware
    {
        public string Capacidade { get; set; }
        public string Velocidade { get; set; }
        public string Tipo { get; set; }

        public DiscoRigido()
        {

        }
        public DiscoRigido(int id, string descricao, double valor, string fabricante, string capacidade,string velocidade, string tipo)
        :base(id, descricao, valor, fabricante)
        {
            Capacidade = capacidade;
            Velocidade = velocidade;
            Tipo = tipo;
        }
    }
}