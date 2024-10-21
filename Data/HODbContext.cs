using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrtizHansEjercicioPractico.Models;

    public class HODbContext : DbContext
    {
        public HODbContext (DbContextOptions<HODbContext> options)
            : base(options)
        {
        }

        public DbSet<OrtizHansEjercicioPractico.Models.Burger> Burger { get; set; } = default!;

public DbSet<OrtizHansEjercicioPractico.Models.Promo> Promo { get; set; } = default!;
    }
