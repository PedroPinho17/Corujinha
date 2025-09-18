using AnotherDotnetToolkit.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace CorujinhaAPI.Infrastructure
{
    public class CorujinhaDbContext : GenericDbContext
    {
        public CorujinhaDbContext(DbContextOptions<CorujinhaDbContext> options) : base(options)
        {
        }
    }
}
