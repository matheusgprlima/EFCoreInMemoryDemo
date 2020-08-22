using AutoMapper;
using EFCoreInMemoryDemo.Business.Models;
using EFCoreInMemoryDemo.ViewModels;
namespace EFCoreInMemoryDemo.AutoMapper
{
	public class AutoMapperConfig : Profile
	{
		public AutoMapperConfig()
		{
			CreateMap<BoardGame, BoardGameViewModel>().ReverseMap();
		}
	}
}
