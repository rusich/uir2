namespace BrickWorks
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class BrickWorksModel : DbContext
    {
        static BrickWorksModel()
        {
            Database.SetInitializer(new MyInitializer());
        }

        public BrickWorksModel()
            : base("BrickWorksModel")
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

    }
}
