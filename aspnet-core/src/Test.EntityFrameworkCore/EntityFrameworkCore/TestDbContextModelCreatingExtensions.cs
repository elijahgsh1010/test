using Microsoft.EntityFrameworkCore;
using Test.SurerClient;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Test.EntityFrameworkCore
{
    public static class TestDbContextModelCreatingExtensions
    {
        public static void ConfigureTest(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(TestConsts.DbTablePrefix + "YourEntities", TestConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            //if (builder.IsHostDatabase())
            //{
            //    /* Tip: Configure mappings like that for the entities only available in the host side,
            //     * but should not be in the tenant databases. */
            //}
            
            builder.Entity<Client>(b =>
            {
                b.ConfigureFullAuditedAggregateRoot();
            });
            
            builder.Entity<ClientGroup>(b =>
            {
                b.ConfigureFullAuditedAggregateRoot();
            });
            
            builder.Entity<Company.Company>(b =>
            {
                b.TryConfigureExtraProperties();
            });
            
            builder.Entity<ClientGroupRelation>()
                .HasKey(x => new { x.ClientId, x.CompanyId, x.FamilyId });

            builder.Entity<ClientGroupRelation>()
                .HasOne(x => x.Client)
                .WithMany(x => x.ClientGroupRelations)
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.NoAction);;

            builder.Entity<ClientGroupRelation>()
                .HasOne(x => x.Company)
                .WithMany(x => x.ClientGroups)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);;
            
            builder.Entity<ClientGroupRelation>()
                .HasOne(x => x.Family)
                .WithMany(x => x.ClientGroups)
                .HasForeignKey(x => x.FamilyId)
                .OnDelete(DeleteBehavior.NoAction);;
        }
    }
}