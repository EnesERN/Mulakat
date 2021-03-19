using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mulakat.Data.Models;
using Mulakat.Services.Movies;
using Mulakat.Web.Helpers;
using Mulakat.Web.Infrastructure;
using Mulakat.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Mulakat.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieService _movieService;
        private readonly MulakatWebHelper _webHelper;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IMovieService movieService, MulakatWebHelper webHelper, IMapper mapper)
        {
            _logger = logger;
            _movieService = movieService;
            _webHelper = webHelper;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View("Movies");
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        public async Task<IActionResult> Movies()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> _ListJSON()
        {
            List<Movie> movies = await _movieService.GetAllMoviesAsync();
            return Ok(new { data = movies });
        }

        [Authorize]
        public async Task<IActionResult> Add()
        {
            return View(new MovieViewModel());
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(MovieViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Add", viewModel);
            }

            Movie movie = _mapper.Map<Movie>(viewModel);

            // resim gönderme front end tarafında arayüz olarak yetişmeyeceğinden rastgele bir resim kullandım
            // backend tarafında resmi kaydeden metod controllera inject edilen MulakatWebHelper classında
            movie.Poster = "https://m.media-amazon.com/images/M/MV5BOTY4YjI2N2MtYmFlMC00ZjcyLTg3YjEtMDQyM2ZjYzQ5YWFkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg";
            Movie movieEntity = await _movieService.InsertMovieAsync(movie);
            return View("Movies");
        }

        [Authorize]
        public async Task<IActionResult> Details(Guid id)
        {
            Movie movie = await _movieService.GetMovieByIdAsync(id);
            MovieViewModel movieViewModel = _mapper.Map<MovieViewModel>(movie);
            return View(movieViewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Details(MovieViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Details", viewModel);
            }

            Movie movie = _mapper.Map<Movie>(viewModel);

            movie.Poster = "https://m.media-amazon.com/images/M/MV5BOTY4YjI2N2MtYmFlMC00ZjcyLTg3YjEtMDQyM2ZjYzQ5YWFkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg";
            Movie movieEntity = await _movieService.UpdateMovieAsync(movie);
            return View("Movies");
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _movieService.RemoveMovieAsync(await _movieService.GetMovieByIdAsync(id));
                return Ok(new { error = false, message = "İşlem Başarılı!" });
            }
            catch (Exception ex)
            {
                return Ok(new { error = true, message = ex.Message });
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
