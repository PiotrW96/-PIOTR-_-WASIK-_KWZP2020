//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP_20_lab1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dostawcy_Oferta
    {
        public int ID_Dostawcy_Oferta { get; set; }
        public Nullable<int> ID_Oferta { get; set; }
        public Nullable<int> ID_Zamowienia { get; set; }
    
        public virtual Oferta Oferta { get; set; }
        public virtual Zamowienia Zamowienia { get; set; }
    }
}