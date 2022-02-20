using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesHistoricalFiguresAC.Models;

    public class RazorPagesHistoricalFiguresACContext : DbContext
    {
        public RazorPagesHistoricalFiguresACContext (DbContextOptions<RazorPagesHistoricalFiguresACContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesHistoricalFiguresAC.Models.HistoricalFiguresAC> HistoricalFiguresAC { get; set; }
    }
