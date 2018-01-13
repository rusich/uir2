namespace BrickWorks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bricksdb.WallSizes")]
    public partial class WallSize
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BuildingId { get; set; }

        [Key]
        [Column(Order = 1)]
        public float WallsLength { get; set; }

        [Key]
        [Column(Order = 2)]
        public float WallsHeight { get; set; }

        public int NumberOfWalls { get; set; }

        public virtual Building Building { get; set; }
    }
}
