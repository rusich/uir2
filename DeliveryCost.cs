namespace BrickWorks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bricksdb.DeliveryCosts")]
    public partial class DeliveryCost
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public float? CostPerKm { get; set; }
    }
}
