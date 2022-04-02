namespace Exercicio4.Entities
{
    class Lagarto : Animal
    {
        public string Classe { get; set; }
        public string Alimentacao { get; set; }
        public string Habitat { get; set; }
        public override string Locomover()
        {
            if (Classe.Equals("Répteis"))
            {
                return "Andar ou Nadar";
            }
            else
            {
                return "Classe incorreta";
            }
        }
        public override string Alimentar()
        {
            if (Alimentacao.Equals("Onívoro"))
            {
                return "Alimentar com mix de Carne e Vegetais";
            }
            else
            {
                return "Alimentação incorreta";
            }
        }

        public override string ToString()
        {
            return "------Lagarto------\n"
            +"Classe: "+Classe+"\n"
            +"Alimentação: "+Alimentacao+ "\n"
            +"Habitat: "+Habitat+"\n"
            +"Locomoção: "+Locomover()+"\n"
            +Alimentar();
        }
    }
}