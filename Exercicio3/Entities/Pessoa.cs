namespace Exercicio3.Entities
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public Pessoa(string nome, string sexo, DateTime dataNascimento)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
        }
        public int ImprimeTempoVidaRestante()
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataNascimento.Year;
            int expecMasc = 80 - idade;
            int expecFem = 73 - idade;
            if (Sexo == "Masculino" || Sexo == "masculino")
            {
                return expecMasc;
            }
            else
            {
                return expecFem;
            }
        }
        public override string ToString()
        {
            return "Nome: "+Nome+"\n"
            +"Sexo: "+Sexo+"\n"
            +"Data de nascimento: "+DataNascimento.ToString("dd/MM/yyyy")+"\n"
            +"Expectativa de vida: é "+ImprimeTempoVidaRestante()+" anos";
        }
    }
}