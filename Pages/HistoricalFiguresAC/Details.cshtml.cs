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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesHistoricalFiguresACContext _context;

        public DetailsModel(RazorPagesHistoricalFiguresACContext context)
        {
            _context = context;
        }

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
    }
}
