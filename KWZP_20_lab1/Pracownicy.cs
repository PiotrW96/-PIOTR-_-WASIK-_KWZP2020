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
    
    public partial class Pracownicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pracownicy()
        {
            this.Dokumentacje = new HashSet<Dokumentacje>();
            this.Magazyn_Dostarczenia_Wewn = new HashSet<Magazyn_Dostarczenia_Wewn>();
            this.Magazyn_Dostarczenia_Zewn = new HashSet<Magazyn_Dostarczenia_Zewn>();
            this.Obsluga_Techniczna = new HashSet<Obsluga_Techniczna>();
            this.Pracownicy_Zatrudnienie = new HashSet<Pracownicy_Zatrudnienie>();
            this.Proces_Technologiczny = new HashSet<Proces_Technologiczny>();
            this.Przydzial_Zasobow = new HashSet<Przydzial_Zasobow>();
            this.Zamowienia = new HashSet<Zamowienia>();
            this.Znajomosc_Jezykow = new HashSet<Znajomosc_Jezykow>();
        }
    
        public int ID_Pracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dokumentacje> Dokumentacje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Magazyn_Dostarczenia_Wewn> Magazyn_Dostarczenia_Wewn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Magazyn_Dostarczenia_Zewn> Magazyn_Dostarczenia_Zewn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obsluga_Techniczna> Obsluga_Techniczna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pracownicy_Zatrudnienie> Pracownicy_Zatrudnienie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_Technologiczny> Proces_Technologiczny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Przydzial_Zasobow> Przydzial_Zasobow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienia> Zamowienia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Znajomosc_Jezykow> Znajomosc_Jezykow { get; set; }
    }
}