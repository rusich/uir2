//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrickWorks
{
    using System;
    using System.Collections.Generic;
    
    public partial class WallSize
    {
        public int BuildingId { get; set; }
        public float WallsLength { get; set; }
        public float WallsHeight { get; set; }
        public Nullable<int> NumberOfWalls { get; set; }
    
        public virtual Building Building { get; set; }
    }
}
