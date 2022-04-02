using System.Globalization;
namespace Exercicio1.Entities
{
    class Hardware
    {
    
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Fabricante { get; set; }
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
        public virtual string DetalhesHardware()
        {
            return "Id: "+Id+"\n"
            +"Descrição "+Descricao+"\n"
            +"Valor "+Valor.ToString("F2", CultureInfo.InvariantCulture)+"\n"
            +"Fabricante "+Fabricante+"\n";
        }
    }
}