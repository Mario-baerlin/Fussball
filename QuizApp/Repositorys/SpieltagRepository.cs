
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
    public class SpieltagRepository : ISpieltagService
    {
        private readonly EndtoendContext _context;

        public SpieltagRepository(EndtoendContext context)
        {
            //_context = new ApplicationDbContext();
            _context = context;
        }

        public async Task AddAsync(Spieltag spieltag)
        {
            _context.spieltag.Add(spieltag);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Spieltag spieltag)
        {
            _context.spieltag.Remove(spieltag);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            _context.spieltag.Remove(await _context.spieltag.Where(x => x.SpieltagGuid == id).FirstOrDefaultAsync());
            await _context.SaveChangesAsync();
        }

        public async Task<List<Spieltag>> GetAllAsync()
        {
            return await _context.spieltag.ToListAsync();
        }

        public async Task<Spieltag> GetAsync(Guid id)
        {
            return await _context.spieltag.Where(x => x.SpieltagGuid == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Spieltag spieltag)
        {
            _context.spieltag.Update(spieltag);
            await _context.SaveChangesAsync();
        }
    }
}
