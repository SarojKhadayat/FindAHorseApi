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
    
    public partial class tblHorseBoxImage
    {
        public int ImageId { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> HorseBoxId { get; set; }
    
        public virtual tblHorseBox tblHorseBox { get; set; }
    }
}