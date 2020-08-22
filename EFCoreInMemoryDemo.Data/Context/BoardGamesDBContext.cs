using EFCoreInMemoryDemo.Business.Models;
using Microsoft.EntityFrameworkCore;
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
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(BoardGamesDBContext).Assembly);

			base.OnModelCreating(modelBuilder);
		}
	}
}
