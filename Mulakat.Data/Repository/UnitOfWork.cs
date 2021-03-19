using Mulakat.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Mulakat.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private MulakatContext _context;
        public UnitOfWork(MulakatContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.Commit();
        }

        public async Task SaveAsync()
        {
            await _context.CommitAsync();
        }
    }
}
