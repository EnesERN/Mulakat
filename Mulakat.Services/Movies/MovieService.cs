using Mulakat.Data.Context;
using Mulakat.Data.Models;
using Mulakat.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulakat.Services.Movies
{
    public class MovieService : IMovieService
    {
        private IUnitOfWork unitOfWork;
        private IGenericRepository<Movie> movieRepo;
        private MulakatContext context;

        public MovieService(IGenericRepository<Movie> movieRepo, UnitOfWork unitOfWork, MulakatContext context)
        {
            this.movieRepo = movieRepo;
            this.unitOfWork = unitOfWork;
            this.context = context;
        }

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            var result = await movieRepo.GetAllAsync();
            return result.ToList();
        }

        public async Task<Movie> GetMovieByIdAsync(Guid id)
        {
            return await movieRepo.GetAsync(u => u.ID == id);
        }

        public async Task<Movie> InsertMovieAsync(Movie movie)
        {
            if (movie == null)
                throw new ArgumentNullException("movie");

            try
            {
                await movieRepo.Insert(movie);
                await SaveAsync();
                return movie;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Movie> UpdateMovieAsync(Movie movie)
        {
            if (movie == null)
                throw new ArgumentNullException("movie");

            try
            {
                movieRepo.Update(movie, x => x.ID, x => x.CreatedDate, x => x.CreatedBy);
                await SaveAsync();
                return movie;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<Movie> RemoveMovieAsync(Movie movie)
        {
            if (movie == null)
                throw new ArgumentNullException("movie");

            try
            {
                movieRepo.Delete(movie);
                await SaveAsync();
                return movie;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task SaveAsync()
        {
            await unitOfWork.SaveAsync();
        }
    }
}
