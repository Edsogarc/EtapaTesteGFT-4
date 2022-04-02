namespace Exercicio4.Entities
{
    class Aguia : Animal
    {
        public string Classe { get; set; }
        public string Alimentacao { get; set; }
        public string Habitat { get; set; }
        public override string Locomover()
        {
            if (Classe.Equals("Aves"))
            {
                return "Voar";
            }
            else
            {
                return "Classe incorreta";
            }
        }
        public override string Alimentar()
        {
            if (Alimentacao.Equals("Carnívoro"))
            {
                return "Alimentar com carne";
            }
            else
            {
                return "Alimenção incorreta";
            }
        }
        public override string ToString()
        {
            return "------Águia------\n" 
            +"Classe: "+Classe+"\n"
            +"Alimentação: "+Alimentacao+ "\n"
            +"Habitat: "+Habitat+"\n"
            +"Locomoção: "+Locomover()+"\n"
            +Alimentar();
        }
    }
}