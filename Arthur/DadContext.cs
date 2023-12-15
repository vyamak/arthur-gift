using Microsoft.EntityFrameworkCore;

internal class DadContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DadContext()
    {
    }

    public DbSet<Child> Children { get; internal set; } = null!;
}
