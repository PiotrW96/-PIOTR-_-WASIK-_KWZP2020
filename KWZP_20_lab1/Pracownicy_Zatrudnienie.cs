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
    
    public partial class Pracownicy_Zatrudnienie
    {
        public int ID_Pracownicy_Zatrudnienie { get; set; }
        public Nullable<int> ID_Pracownika { get; set; }
        public Nullable<int> ID_Stanowiska { get; set; }
        public Nullable<int> ID_Etatu { get; set; }
        public Nullable<int> ID_Rodzaju_Umowy { get; set; }
        public System.DateTime Data_Zatrudnienia { get; set; }
        public System.DateTime Koniec_umowy { get; set; }
    
        public virtual Etat Etat { get; set; }
        public virtual Pracownicy Pracownicy { get; set; }
        public virtual Rodzaj_Umowy Rodzaj_Umowy { get; set; }
        public virtual Stanowisko Stanowisko { get; set; }
    }
}
