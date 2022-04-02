using System.Globalization;
namespace Exercicio1.Entities
{
    class Memoria : Hardware
    {
        public string Frequencia { get; set; }
        public string Capacidade { get; set; }
        public string Tipo { get; set; }
        
        public Memoria()
        {

        }

        public Memoria(int id, string descricao, double valor, string fabricante, string frequencia, string capacidade, string tipo)
        :base(id, descricao, valor, fabricante)
        {
            Frequencia = frequencia;
            Capacidade = capacidade;
            Tipo = tipo;
        }
        public override string DetalhesHardware()
        {
            return "-----Memoria-----\n"
            +"Id: "+Id+"\n"
            +"Descrição: "+Descricao+"\n"
            +"Valor: R$"+Valor.ToString("F2", CultureInfo.InvariantCulture)+"\n"
            +"Fabricante: "+Fabricante+"\n"
            +"Frequência: "+ Frequencia+"Mhz Capacidade: "+Capacidade + "GB Tipo: "+Tipo; 
        }
    }
}