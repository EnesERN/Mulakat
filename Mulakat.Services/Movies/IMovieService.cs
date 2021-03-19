using Mulakat.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulakat.Services.Movies
{
    public interface IMovieService
    {
        Task<Movie> GetMovieByIdAsync(Guid id);
        Task<List<Movie>> GetAllMoviesAsync();

        Task<Movie> InsertMovieAsync(Movie movie);
        Task<Movie> UpdateMovieAsync(Movie movie);
        Task<Movie> RemoveMovieAsync(Movie movie);

        Task SaveAsync();
    }
}
