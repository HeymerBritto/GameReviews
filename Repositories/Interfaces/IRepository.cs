using GameReviews.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameReviews.Repositories.Interfaces
{
    public interface IRepository<T> where T : ModeloBase
    {
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T review);
    }
}
