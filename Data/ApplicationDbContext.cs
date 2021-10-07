using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SSDLab1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSDLab1.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Database tables
        public DbSet<Team> Teams { get; set; }
    }
}
