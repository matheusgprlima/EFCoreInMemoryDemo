using EFCoreInMemoryDemo.Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace EFCoreInMemoryDemo.Data.Context
{
	public class BoardGamesDBContext : DbContext
	{
		public BoardGamesDBContext(DbContextOptions options) : base(options)
		{

		}
		public DbSet<BoardGame> BoardGames { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			foreach (var property in modelBuilder.Model.GetEntityTypes()
				.SelectMany(e => e.GetProperties()
				.Where(p => p.ClrType == typeof(string))))
				property.SetMaxLength(200);

			modelBuilder.ApplyConfigurationsFromAssembly(typeof(BoardGamesDBContext).Assembly);

			base.OnModelCreating(modelBuilder);
		}
	}
}
