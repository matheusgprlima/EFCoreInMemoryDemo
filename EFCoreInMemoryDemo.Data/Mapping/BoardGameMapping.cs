using EFCoreInMemoryDemo.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EFCoreInMemoryDemo.Data.Mapping
{
	public class BoardGameMapping : IEntityTypeConfiguration<BoardGame>
	{
		public void Configure(EntityTypeBuilder<BoardGame> builder)
		{
			builder
				.HasKey(b => b.Id);

			builder
				.HasIndex(b => b.Title)
				.IsUnique();

			builder
				.Property(b => b.PublishingCompany)
				.IsRequired()
				.HasColumnType("varchar(200)");

			builder
				.Property(b => b.Price)
				.IsRequired()
				.HasColumnType("decimal(18,2)");

			builder.ToTable("BoardGames");
		}
	}
}
