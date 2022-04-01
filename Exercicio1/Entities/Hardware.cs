namespace Exercicio1.Entities
{
    class Hardware
    {
    
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Fabricante { get; set; }
        public Cpu Get { get; set; }
        public Memoria GetM { get; set; }
        public DiscoRigido GetD { get; set; }
        public Hardware()
        {
            
        }
        public Hardware(int id, string descricao, double valor, string fabricante)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            Fabricante = fabricante;
        }
        public override string ToString()
        {
            return "Id: "+Id+"\n"
            +"Descrição "+ Descricao+"\n"
            +"Valor +"+Valor+"\n"
            +"Fabricante "+Fabricante+"\n"
            +"CPU "+ "Clock "+Get.Clock + " Modelo "+Get.Modelo+"\n"
            +"Memoria +"+GetM.Capacidade + GetM.Capacidade + GetM.Tipo+"\n"
            +"Disco rigido "+ GetD.Capacidade + GetD.Velocidade + GetD.Tipo;
    
        }
    }
}