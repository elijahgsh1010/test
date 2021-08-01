using Microsoft.EntityFrameworkCore;

namespace Test.EntityFrameworkCore
{
    public class TestMigrationsDbContextFactory :
        TestMigrationsDbContextFactoryBase<TestMigrationsDbContext>
    {
        protected override TestMigrationsDbContext CreateDbContext(
            DbContextOptions<TestMigrationsDbContext> dbContextOptions)
        {
            return new TestMigrationsDbContext(dbContextOptions);
        }
    }
}
