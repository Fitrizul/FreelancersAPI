using FreelancersAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FreelancersAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
