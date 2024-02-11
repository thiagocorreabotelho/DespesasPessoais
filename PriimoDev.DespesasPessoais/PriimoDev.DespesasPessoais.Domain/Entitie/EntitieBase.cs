namespace PriimoDev.DespesasPessoais.Domain.Entitie
{
    public abstract class EntitieBase
    {
        protected EntitieBase(int id, DateTime dataCriacao, DateTime dataModificacao)
        {
            Id = id;
            DataCriacao = dataCriacao;
            DataModificacao = dataModificacao;
        }

        public int Id { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataModificacao { get; private set; }
    }
}
