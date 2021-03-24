using QuizApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public interface ISpieltagService
    {
        Task<List<Spieltag>> GetAllAsync();
        Task<Spieltag> GetAsync(Guid id);
        Task AddAsync(Spieltag spieltag);
        Task UpdateAsync(Spieltag spieltag);
        Task DeleteByIdAsync(Guid id);
        Task DeleteAsync(Spieltag spieltag);
    }
}
