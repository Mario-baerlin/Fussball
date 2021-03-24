
using Microsoft.EntityFrameworkCore;
using QuizApp.Data;
using QuizApp.Data.EndToEnd;
using QuizApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Repositorys
{
    public class ResultRepository : IMatchService
    {
        private readonly EndtoendContext _context;

        public ResultRepository(EndtoendContext context)
        {
            //_context = new ApplicationDbContext();
            _context = context;
        }

        public async Task AddAsync(Match match)
        {
            _context.match.Add(match);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Match match)
        {
            _context.match.Remove(match);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            _context.match.Remove(await _context.match.Where(x => x.SpieltagGuid == id).FirstOrDefaultAsync());
            await _context.SaveChangesAsync();
        }

       

       

        public async Task UpdateAsync(Match match)
        {
            _context.match.Update(match);
            await _context.SaveChangesAsync();
        }

       

        public async Task<List<Match>> GetAllAsync()
        {
            return await _context.match.ToListAsync();
        }

        public async Task<Match> GetAsync(Guid id)
        {
            return await _context.match.Where(x => x.SpieltagGuid == id).FirstOrDefaultAsync();
        }
    }
}
