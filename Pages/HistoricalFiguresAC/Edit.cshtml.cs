using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesHistoricalFiguresAC.Models;

namespace RazorPagesHistoricalFiguresAC.Pages_HistoricalFiguresAC
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesHistoricalFiguresACContext _context;

        public EditModel(RazorPagesHistoricalFiguresACContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HistoricalFiguresAC).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoricalFiguresACExists(HistoricalFiguresAC.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HistoricalFiguresACExists(int id)
        {
            return _context.HistoricalFiguresAC.Any(e => e.ID == id);
        }
    }
}
