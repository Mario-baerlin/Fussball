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
    public class VereinRepository : IVereinService
    {
        private readonly EndtoendContext _context;

        public VereinRepository(EndtoendContext context)
        {
            //_context = new ApplicationDbContext();
            _context = context;
        }

        public async Task AddAsync(Verein verein)
        {
            _context.verein.Add(verein);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Verein verein)
        {
            _context.verein.Remove(verein);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            _context.verein.Remove(await _context.verein.Where(x => x.VereinGuid == id).FirstOrDefaultAsync());
            await _context.SaveChangesAsync();
        }

        public async Task<List<Verein>> GetAllAsync()
        {
            return await _context.verein.ToListAsync();
        }

        public async Task<Verein> GetAsync(Guid id)
        {
            return await _context.verein.Where(x => x.VereinGuid == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Verein verein)
        {
            _context.verein.Update(verein);
            await _context.SaveChangesAsync();
        }
    }
}
