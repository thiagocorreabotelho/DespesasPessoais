using PriimoDev.DespesasPessoais.Domain.Entitie;

namespace PriimoDev.DespesasPessoais.Domain.Interface
{
    public interface IRepositorioBase<TEntity> : IDisposable where TEntity : EntitieBase
    {
        /// <summary>
        /// Contrato de interface responsável pela lista genérica.
        /// </summary>
        /// <returns>Retorna uma lista com base na entidade fornecida</returns>
        Task<IEnumerable<TEntity>> ObterListaAsync();

        /// <summary>
        /// Contrato de interface responsável por consultar objeto pelo código de identificação.
        /// </summary>
        /// <param name="id">Código de identificação.</param>
        /// <returns>Retorna objeto simples.</returns>
        Task<TEntity> ObterPorId(int id);

        /// <summary>
        /// Contrato de interface responsável por adicionar novos registro.
        /// </summary>
        /// <param name="entity">Entidade genérica.</param>
        void Novo(TEntity entity);

        /// <summary>
        /// Contrato de interface responsável por atualizar registros.
        /// </summary>
        /// <param name="entity">Entidade genérica.</param>
        void Alterar(TEntity entity);

        /// <summary>
        /// Contrato de interface responsável por excluir registros.
        /// </summary>
        /// <param name="entity">Entidade genérica.</param>
        void Excluir(TEntity entity);

        /// <summary>
        /// Contrato de interface responsável por salvar operações na base.
        /// </summary>
        /// <returns>True para sucesso e false caso falha ao salvar no banco.</returns>
        Task<bool> SalvarAsync();

        /// <summary>
        /// Contrato de interface responsável por iniciar uma nova transação.
        /// </summary>
        Task BeginTranAsync();

        /// <summary>
        /// Contrato de interface responsável por commitar as transações realizada.
        /// </summary>
        Task CommitAsync();

        /// <summary>
        /// Contrato de interface responsavel por dar rollback nas transações mal sucedidas.
        /// </summary>
        Task RollbackAsync();

    }
}
