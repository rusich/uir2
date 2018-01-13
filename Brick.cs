namespace BrickWorks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bricksdb.Bricks")]
    public partial class Brick
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Brick()
        {
            BrickCosts = new HashSet<BrickCost>();
            ManufacturedBricks = new HashSet<ManufacturedBrick>();
            OrderedBricks = new HashSet<OrderedBrick>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string Mark { get; set; }

        public float? Height { get; set; }

        public float? Lenght { get; set; }

        public float? Weight { get; set; }

        [StringLength(40)]
        public string Parameters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BrickCost> BrickCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManufacturedBrick> ManufacturedBricks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderedBrick> OrderedBricks { get; set; }
    }
}
