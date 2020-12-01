using System;
using ProjetoModeloDDD.Domain.Interfaces;


namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoty<TEntity> where TEntity : class 
    {
    }
}
