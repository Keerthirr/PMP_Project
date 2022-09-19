using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace PensionManagementPortal.Models
{
    public interface IPMPContext
    {
        DbSet<Login> Logins { get; set; }
        DbSet<Pensioner> Pensioners { get; set; }

        Task<int> SaveChanges();
    }
}