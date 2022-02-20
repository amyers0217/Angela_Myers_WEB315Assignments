using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesHistoricalFiguresAC.Models;

namespace RazorPagesHistoricalFiguresAC.Pages_HistoricalFiguresAC
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesHistoricalFiguresACContext _context;

        public DeleteModel(RazorPagesHistoricalFiguresACContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HistoricalFiguresAC HistoricalFiguresAC { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HistoricalFiguresAC = await _context.HistoricalFiguresAC.FirstOrDefaultAsync(m => m.ID == id);

            if (HistoricalFiguresAC == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HistoricalFiguresAC = await _context.HistoricalFiguresAC.FindAsync(id);

            if (HistoricalFiguresAC != null)
            {
                _context.HistoricalFiguresAC.Remove(HistoricalFiguresAC);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
