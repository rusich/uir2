namespace BrickWorks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Bricks")]
    public partial class Brick
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Brick()
        {
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string Mark { get; set; }

        [Required]
        public float Height { get; set; }

        [Required]
        public float Lenght { get; set; }

        [Required]
        public float Width { get; set; }

        [StringLength(40)]
        public string Parameters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BrickCost> BrickCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManufacturedBrick> ManufacturedBricks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderedBrick> OrderedBricks { get; set; }

        public int RemainingBricks
        {
            get
            {
                BrickWorksModel db = new BrickWorksModel();
                var mBricks = db.ManufacturedBricks.Where(b => b.BrickId == Id).ToList();
                var oBricks = db.OrderedBricks.Where(b => b.BrickId == Id).ToList();
                int remainingBricks = (mBricks.Sum(m => m.Quantity) - oBricks.Sum(o => o.Quantity));
                
                return remainingBricks;
            }
        }
    }
}
