namespace EFCoreInMemoryDemo.Business.Models
{
	public class BoardGame : Entity
	{
		public string Title { get; set; }
		public string PublishingCompany { get; set; }
		public int MinPlayers { get; set; }
		public int MaxPlayers { get; set; }
		public decimal Price { get; set; }
	}
}
