using _Net_Projetcts.Models;
using Microsoft.EntityFrameworkCore;

namespace _Net_Projetcts;

public class SpendSmartDbContext : DbContext
{
    public DbSet<Expanse> Expanses {get; set;}

    public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options) 
     :base(options)
    {
        
    }
}
