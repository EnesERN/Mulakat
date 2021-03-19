using Mulakat.Data.Context;
using Mulakat.Data.Helpers;
using Mulakat.Data.Models;
using Mulakat.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulakat.Services.Users
{
    public class UserService : IUserService
    {

        private IUnitOfWork unitOfWork;
        private IGenericRepository<User> userRepo;
        private MulakatContext context;

        public UserService(IGenericRepository<User> userRepo, UnitOfWork unitOfWork, MulakatContext context)
        {
            this.userRepo = userRepo;
            this.unitOfWork = unitOfWork;
            this.context = context;
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await userRepo.GetAsync(u => u.ID == id);
        }

        public async Task<User> GetUserAsync(string eMail, string password)
        {
            password = MulakatHelper.HashPassword(password).ToString();
            return await userRepo.GetAsync(u => u.Email == eMail && u.Password == password);
        }

        public async Task<User> InsertUserAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException("User");

            try
            {
                user.Password = MulakatHelper.HashPassword(user.Password).ToString();
                await userRepo.Insert(user);
                await SaveAsync();
                return user;
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
