namespace BrickWorks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WallSizes")]
    public partial class WallSize
    {
        [Key]
        public int Id { get; set; }

        public int BuildingId { get; set; }

        public float WallsLength { get; set; }

        public float WallsHeight { get; set; }

        public int NumberOfWalls { get; set; }

        public virtual Building Building { get; set; }
    }
}
