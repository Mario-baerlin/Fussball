using QuizApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public interface IMatchService
    {
        Task<List<Match>> GetAllAsync();
        Task<Match> GetAsync(Guid id);
        Task AddAsync(Match result);
        Task UpdateAsync(Match result);
        Task DeleteByIdAsync(Guid id);
        Task DeleteAsync(Match result);
    }
}
