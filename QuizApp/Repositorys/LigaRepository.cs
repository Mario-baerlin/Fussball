
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
    public class LigaRepository : ILigaService
    {
        private readonly EndtoendContext _context;

        public LigaRepository(EndtoendContext context)
        {
            //_context = new ApplicationDbContext();
            _context = context;
        }

        public async Task AddAsync(Liga liga)
        {
            _context.liga.Add(liga);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Liga liga)
        {
            _context.liga.Remove(liga);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            _context.liga.Remove(await _context.liga.Where(x => x.LigaGuid == id).FirstOrDefaultAsync());
            await _context.SaveChangesAsync();
        }

        public async Task<List<Liga>> GetAllAsync()
        {
            return await _context.liga.ToListAsync();
        }

        public async Task<Liga> GetAsync(Guid id)
        {
            return await _context.liga.Where(x => x.LigaGuid == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Liga liga)
        {
            _context.liga.Update(liga);
            await _context.SaveChangesAsync();
        }
    }
}
