using Exercicio4.Services;

namespace Exercicio4.Entities
{
    abstract class Animal : IAcoesAnimais
    {
        public abstract string Locomover();
        public abstract string Alimentar();
    }
}