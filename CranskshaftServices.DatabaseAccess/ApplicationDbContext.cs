using CrankshaftServices.Models.Foundation;
using Microsoft.EntityFrameworkCore;

namespace HorsePowerLtd.DbAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Foundation
        public DbSet<Title> Titles { get; set; }
    }
}