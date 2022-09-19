using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensionManagementPortal.Models
{
    public class PMPContext : DbContext, IPMPContext
    {
        public PMPContext(DbContextOptions<PMPContext> options) : base(options)
        {

        }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Pensioner> Pensioners { get; set; }
        public new async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
