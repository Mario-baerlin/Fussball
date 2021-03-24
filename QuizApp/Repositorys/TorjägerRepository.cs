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
    public class TorjägerRepository : ITorjägerService
    {
        private readonly EndtoendContext _context;

        public TorjägerRepository(EndtoendContext context)
        {
            //_context = new ApplicationDbContext();
            _context = context;
        }

        public async Task AddAsync(Torjäger torjäger)
        {
            _context.torjäger.Add(torjäger);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Torjäger torjäger)
        {
            _context.torjäger.Remove(torjäger);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            _context.torjäger.Remove(await _context.torjäger.Where(x => x.MatchGuid == id).FirstOrDefaultAsync());
            await _context.SaveChangesAsync();
        }

        public async Task<List<Torjäger>> GetAllAsync()
        {
            return await _context.torjäger.ToListAsync();
        }

        public async Task<Torjäger> GetAsync(Guid id)
        {
            return await _context.torjäger.Where(x => x.TorjägerGuid == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Torjäger torjäger)
        {
            _context.torjäger.Update(torjäger);
            await _context.SaveChangesAsync();
        }
    }
}
