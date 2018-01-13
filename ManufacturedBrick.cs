namespace BrickWorks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bricksdb.ManufacturedBricks")]
    public partial class ManufacturedBrick
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int BrickId { get; set; }

        public int Quantity { get; set; }

        public virtual Brick Brick { get; set; }
    }
}
