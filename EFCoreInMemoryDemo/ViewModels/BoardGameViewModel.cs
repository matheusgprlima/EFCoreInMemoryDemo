using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace EFCoreInMemoryDemo.ViewModels
{
	public class BoardGameViewModel
	{
		[Key]
		public Guid Id { get; set; }

		[Required(ErrorMessage = "This Field Is Required.")]
		[StringLength(200, ErrorMessage = "Character Limit Reached")]
		public string Title { get; set; }

		[DisplayName("Publishing Company")]
		[Required(ErrorMessage = "This Field Is Required.")]

		public string PublishingCompany { get; set; }

		[DisplayName("Min Players")]
		[Required(ErrorMessage = "This Field Is Required.")]
		public int MinPlayers { get; set; }

		[DisplayName("Max Players")]
		[Required(ErrorMessage = "This Field Is Required.")]
		public int MaxPlayers { get; set; }

		[Required(ErrorMessage = "This Field Is Required.")]
		public decimal Price { get; set; }
	}
}
