using AutoMapper;
using EFCoreInMemoryDemo.Business.Interfaces;
using EFCoreInMemoryDemo.Business.Models;
using EFCoreInMemoryDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EFCoreInMemoryDemo.Controllers
{
	public class BoardGamesController : Controller
	{
		private readonly IBoardGameRepository _boardGameRepository;
		private readonly IMapper _mapper;

		public BoardGamesController(IBoardGameRepository boardGameRepository, IMapper mapper)
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
		public IActionResult Add()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Add(BoardGameViewModel boardGameViewModel)
		{
			if (!ModelState.IsValid) return View(boardGameViewModel);

			var boardGame = _mapper.Map<BoardGame>(boardGameViewModel);

			await _boardGameRepository.Adicionar(boardGame);

			return RedirectToAction(nameof(Index));
		}
		public async Task<IActionResult> Edit(Guid id)
		{
			var boardGameViewModel = _mapper.Map<BoardGameViewModel>(await _boardGameRepository.ObterPorId(id));

			if (boardGameViewModel == null)
			{
				return NotFound();
			}
			return View(boardGameViewModel);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(Guid id, BoardGameViewModel boardGameViewModel)
		{
			if (!ModelState.IsValid) return View(boardGameViewModel);

			var boardGame = _mapper.Map<BoardGame>(boardGameViewModel);

			await _boardGameRepository.Atualizar(boardGame);

			return RedirectToAction(nameof(Index));
		}
		public async Task<IActionResult> Delete(Guid id)
		{
			var boardGameViewModel = _mapper.Map<BoardGameViewModel>(await _boardGameRepository.ObterPorId(id));

			if (boardGameViewModel == null)
			{
				return NotFound();
			}
			return View(boardGameViewModel);
		}
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(Guid id)
		{
			var boardGameViewModel = _mapper.Map<BoardGameViewModel>(await _boardGameRepository.ObterPorId(id));

			if (boardGameViewModel == null) return NotFound();

			await _boardGameRepository.Remover(id);

			return RedirectToAction(nameof(Index));
		}
	}
}
