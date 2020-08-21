using System;
namespace EFCoreInMemoryDemo.Business.Models
{
	public abstract class Entity
	{
		protected Entity()
		{
			Id = Guid.NewGuid();
		}
		public Guid Id { get; set; }

	}

}
