using QuizApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public interface IVereinService
    {
        Task<List<Verein>> GetAllAsync();
        Task<Verein> GetAsync(Guid id);
        Task AddAsync(Verein verein);
        Task UpdateAsync(Verein verein);
        Task DeleteByIdAsync(Guid id);
        Task DeleteAsync(Verein verein);
    }
}
