using AutoMapper;
using EFCoreInMemoryDemo.Business.Interfaces;
using EFCoreInMemoryDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreInMemoryDemo.Controllers
{
	public class BoardGameController : Controller
	{
		private readonly IBoardGameRepository _boardGameRepository;
		private readonly IMapper _mapper;

		public BoardGameController(IBoardGameRepository boardGameRepository, IMapper mapper)
		{
			_boardGameRepository = boardGameRepository;
			_mapper = mapper;
		}
		public async Task<IActionResult> Index()
		{
			return View(_mapper.Map<IEnumerable<BoardGameViewModel>>(await _boardGameRepository.ObterTodos()).OrderBy(p => p.Title));
		}

		public async Task<IActionResult> Details(Guid id)
		{
			var boardGameViewModel = _mapper.Map<BoardGameViewModel>(await _boardGameRepository.ObterPorId(id));
			if (boardGameViewModel == null)
			{
				return NotFound();
			}

			return View(boardGameViewModel);
		}
	}
}
