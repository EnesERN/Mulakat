using Mulakat.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulakat.Services.Users
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(Guid id);
        Task<User> GetUserAsync(string eMail, string password);

        Task<User> InsertUserAsync(User user);

        Task SaveAsync();
    }
}
