using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : BaseRecord
    {
        public virtual Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
