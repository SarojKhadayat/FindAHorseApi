//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FindAHorseApiModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblHorseBox
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHorseBox()
        {
            this.tblBookingMasters = new HashSet<tblBookingMaster>();
            this.tblHorseBoxImages = new HashSet<tblHorseBoxImage>();
        }
    
        public int HorseBoxId { get; set; }
        public bool IsAirConditioned { get; set; }
        public bool HasCameras { get; set; }
        public bool HasAccomodation { get; set; }
        public Nullable<decimal> Tonnage { get; set; }
        public int Age { get; set; }
        public Nullable<int> RampId { get; set; }
        public string AvailableDates { get; set; }
        public Nullable<int> UserId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBookingMaster> tblBookingMasters { get; set; }
        public virtual tblRamp tblRamp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHorseBoxImage> tblHorseBoxImages { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
