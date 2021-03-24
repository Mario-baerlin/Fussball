using QuizApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public interface ILigaService
    {
        Task<List<Liga>> GetAllAsync();
        Task<Liga> GetAsync(Guid id);
        Task AddAsync(Liga liga);
        Task UpdateAsync(Liga liga);
        Task DeleteByIdAsync(Guid id);
        Task DeleteAsync(Liga liga);
    }
}
