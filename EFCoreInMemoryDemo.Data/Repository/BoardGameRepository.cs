using EFCoreInMemoryDemo.Business.Interfaces;
using EFCoreInMemoryDemo.Business.Models;
using EFCoreInMemoryDemo.Data.Context;

namespace EFCoreInMemoryDemo.Data.Repository
{
	public class BoardGameRepository : Repository<BoardGame>, IBoardGameRepository
	{
		public BoardGameRepository(BoardGamesDBContext context) : base(context)
		{

		}
	}
}
