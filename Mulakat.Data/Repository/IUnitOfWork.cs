using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulakat.Data.Repository
{
    public interface IUnitOfWork
    {
        void Save();
        Task SaveAsync();
    }
}
