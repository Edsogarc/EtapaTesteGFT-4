using System.Globalization;
namespace Exercicio1.Entities
{
    class Cpu : Hardware
    {
        public string Clock { get; set; }
        public string Modelo { get; set; }

        public Cpu()
        {
            
        }

        public Cpu(int id, string descricao, double valor, string fabricante, string clock, string modelo)
        :base(id, descricao, valor, fabricante)
        {
            Clock = clock;
            Modelo = modelo;
        }
        public override string DetalhesHardware()
        {
            return "-----CPU-----\n"
            +"Id: "+Id+"\n"
            +"Descrição: "+Descricao+"\n"
            +"Valor: R$"+Valor.ToString("F2", CultureInfo.InvariantCulture)+"\n"
            +"Fabricante: "+Fabricante+"\n"
            +"Clock: "+Clock + "Ghz Modelo: "+Modelo;
        }
        
    }
}