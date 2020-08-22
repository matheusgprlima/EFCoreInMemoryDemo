using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace EFCoreInMemoryDemo.ViewModels
{
	public class BoardGameViewModel
	{
		[Key]
		public Guid Id { get; set; }

		[Required(ErrorMessage = "O campo é obrigatório")]
		[StringLength(200, ErrorMessage = "Máximo de 200 caracteres")]
		public string Title { get; set; }

		[DisplayName("Publishing Company")]
		[Required(ErrorMessage = "O campo é obrigatório")]
		public string PublishingCompany { get; set; }

		[DisplayName("Min Players")]
		[Required(ErrorMessage = "O campo é obrigatório")]
		public int MinPlayers { get; set; }

		[DisplayName("Max Players")]
		[Required(ErrorMessage = "O campo é obrigatório")]
		public int MaxPlayers { get; set; }

		[Required(ErrorMessage = "O campo é obrigatório")]
		public decimal Price { get; set; }
	}
}
