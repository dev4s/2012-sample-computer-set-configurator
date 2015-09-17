using System.Data.Entity;

namespace SampleComputerSetConfigurator.Database
{
	public class ComputerSetDatabaseContext : DbContext
	{
		public DbSet<AdditionalService> AdditionalServices { get; set; }
		public DbSet<ComputerPart> ComputerParts { get; set; }
		public DbSet<ComputerPartDetail> ComputerPartDetails { get; set; }
		public DbSet<ComputerPartDetailType> ComputerPartDetailTypes { get; set; }
		public DbSet<ComputerPartGroup> ComputerPartGroups { get; set; }
		public DbSet<Order> Orders { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Order>().HasMany(x => x.ComputerParts).WithMany(y => y.Orders);
			modelBuilder.Entity<Order>().HasMany(x => x.AdditionalServices).WithMany(y => y.Orders);
			modelBuilder.Entity<ComputerPartGroup>().HasMany(x => x.Children);

			base.OnModelCreating(modelBuilder);
		}
	}
}