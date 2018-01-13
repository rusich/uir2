namespace BrickWorks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bricksdb.OrderedBricks")]
    public partial class OrderedBrick
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int BrickId { get; set; }

        public int Quantity { get; set; }

        public virtual Brick Brick { get; set; }

        public virtual Order Order { get; set; }
    }
}
