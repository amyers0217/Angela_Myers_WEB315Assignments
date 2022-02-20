using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesHistoricalFiguresAC.Models;

namespace RazorPagesHistoricalFiguresAC.Pages_HistoricalFiguresAC
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesHistoricalFiguresACContext _context;

        public CreateModel(RazorPagesHistoricalFiguresACContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HistoricalFiguresAC HistoricalFiguresAC { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HistoricalFiguresAC.Add(HistoricalFiguresAC);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
