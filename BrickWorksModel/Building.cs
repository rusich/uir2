namespace BrickWorks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buildings")]
    public partial class Building
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Building()
        {
            WallSizes = new HashSet<WallSize>();
        }

        public int Id { get; set; }

        public int ClientID { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public float? DeliveryDistanse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WallSize> WallSizes { get; set; }

        public virtual Client Client { get; set; }
    }
}
