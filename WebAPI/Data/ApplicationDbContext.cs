using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Entities;

namespace WebAPI.Data
{
    public class ApplicationDbContext: IdentityDbContext<AppUser>
    {
        public ApplicationDbContext()
        { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<JobSeeker> JobSeekers { get; set; }
    }
}
