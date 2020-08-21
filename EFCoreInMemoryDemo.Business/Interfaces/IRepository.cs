using EFCoreInMemoryDemo.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreInMemoryDemo.Business.Interfaces
{
	public interface IRepository<TEntity> : IDisposable where TEntity : Entity
	{
		Task Adicionar(TEntity entity);

		Task<TEntity> ObterPorId(Guid id);

		Task<List<TEntity>> ObterTodos();
	}
}
