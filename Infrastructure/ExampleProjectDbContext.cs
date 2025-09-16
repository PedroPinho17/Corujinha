using AnotherDotnetToolkit.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Monolitic_CQRS_Template.Infrastructure
{
    public class ExampleProjectDbContext : GenericDbContext
    {
        public ExampleProjectDbContext(DbContextOptions<ExampleProjectDbContext> options) : base(options)
        {
        }
    }
}
