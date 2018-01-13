namespace BrickWorks
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BrickWorksModel : DbContext
    {
        public BrickWorksModel()
            : base("name=BrickWorksModel")
        {
        }

        public virtual DbSet<BrickCost> BrickCosts { get; set; }
        public virtual DbSet<Brick> Bricks { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<DeliveryCost> DeliveryCosts { get; set; }
        public virtual DbSet<ManufacturedBrick> ManufacturedBricks { get; set; }
        public virtual DbSet<OrderedBrick> OrderedBricks { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<WallSize> WallSizes { get; set; }
        public virtual DbSet<OrdersView> OrdersViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brick>()
                .Property(e => e.Mark)
                .IsUnicode(false);

            modelBuilder.Entity<Brick>()
                .Property(e => e.Parameters)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
