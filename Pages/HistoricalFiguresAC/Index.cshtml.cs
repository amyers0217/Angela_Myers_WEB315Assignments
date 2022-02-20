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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesHistoricalFiguresACContext _context;

        public IndexModel(RazorPagesHistoricalFiguresACContext context)
        {
            _context = context;
        }

        public IList<HistoricalFiguresAC> HistoricalFiguresAC { get;set; }

        public async Task OnGetAsync()
        {
            HistoricalFiguresAC = await _context.HistoricalFiguresAC.ToListAsync();
        }
    }
}
