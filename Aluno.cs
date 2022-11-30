namespace Tester.Domain
{
    public class Aluno : Entity
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        protected Aluno() { }
        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public void AlterarNome(string nome) => Nome = nome;
        public void AlterarIDade(int idade) => Idade = idade;
    }
}
