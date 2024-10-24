using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using todo.Models;

namespace todo.Pages
{
    public class KartyaModel : PageModel
    {
        private readonly JegyzetekDbContext _context;
        public IList<Kartya> Kartyak { get; set; }

        [BindProperty]
        public Jegyzet UjJegyzet { get; set; }

        public async Task OnGetAsync()
        {
            Kartyak = await _context.Kartyak.Include(k => k.Jegyzetek).ToListAsync();
        }

        public async Task<IActionResult> OnPostCreateAsync(string newKartyaNev)
        {
            if (!string.IsNullOrEmpty(newKartyaNev))
            {
                var újKártya = new Kartya { nev = newKartyaNev };
                _context.Kartyak.Add(újKártya);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostAddNoteAsync(int kartyaId, string newNote)
        {
            var kártya = await _context.Kartyak.FindAsync(kartyaId);

            if (kártya != null && !string.IsNullOrEmpty(newNote))
            {
                var jegyzet = new Jegyzet
                {
                    tartalom = newNote,
                    letrehozasIdeje = DateTime.Now,
                    kartyaID = kartyaId
                };
                _context.Jegyzetek.Add(jegyzet);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteNoteAsync(int jegyzetId)
        {
            var jegyzet = await _context.Jegyzetek.FindAsync(jegyzetId);

            if (jegyzet != null)
            {
                _context.Jegyzetek.Remove(jegyzet);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteKartyaAsync(int id)
        {
            var kártya = await _context.Kartyak.FindAsync(id);

            if (kártya != null)
            {
                _context.Kartyak.Remove(kártya);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}