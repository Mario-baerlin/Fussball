using QuizApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public interface ITorjägerService
    {
        Task<List<Torjäger>> GetAllAsync();
        Task<Torjäger> GetAsync(Guid id);
        Task AddAsync(Torjäger torjäger);
        Task UpdateAsync(Torjäger torjäger);
        Task DeleteByIdAsync(Guid id);
        Task DeleteAsync(Torjäger torjäger);
    }
}
