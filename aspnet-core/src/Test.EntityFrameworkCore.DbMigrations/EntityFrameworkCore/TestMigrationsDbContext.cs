using Microsoft.EntityFrameworkCore;
using Test.SurerClient;
using Volo.Abp.MultiTenancy;

namespace Test.EntityFrameworkCore
{
    public class TestMigrationsDbContext : TestMigrationsDbContextBase<TestMigrationsDbContext>
    {
        public DbSet<SurerClient.ClientGroupRelation> ClientGroupRelation { get; set; }
        public DbSet<Family.Family> Family { get; set; }
        public DbSet<Company.Company> Company { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<ClientGroup> ClientGroup { get; set; }
        public TestMigrationsDbContext(DbContextOptions<TestMigrationsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SetMultiTenancySide(MultiTenancySides.Both);

            base.OnModelCreating(builder);
        }
    }
}
