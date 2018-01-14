namespace BrickWorks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BrickCosts")]
    public partial class BrickCost
    {
        public int Id { get; set; }

        public int BrickId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public float Cost { get; set; }

        public virtual Brick Brick { get; set; }
    }
}
