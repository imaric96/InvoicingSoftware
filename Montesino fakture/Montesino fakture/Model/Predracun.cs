//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Montesino_fakture.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Predracun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Predracun()
        {
            this.PredracunStavkes = new HashSet<PredracunStavke>();
        }
    
        public int Predracun_ID { get; set; }
        public Nullable<int> Ponuda_ID { get; set; }
        public string Broj { get; set; }
        public System.DateTime Datum { get; set; }
        public System.DateTime RokIsporuke { get; set; }
        public int Subjekat_ID { get; set; }
        public int Primalac_ID { get; set; }
        public short RokVazenja { get; set; }
        public Nullable<int> NP_ID { get; set; }
        public Nullable<int> Status_ID { get; set; }
        public Nullable<int> Valuta_ID { get; set; }
        public Nullable<int> OdgovorneOsobe_ID { get; set; }
        public Nullable<int> Posta_ID { get; set; }
        public string Napomena { get; set; }
        public Nullable<decimal> Ukupno { get; set; }
        public Nullable<decimal> PopustBroj { get; set; }
        public Nullable<decimal> PopustProcenat { get; set; }
        public Nullable<decimal> Vrednost { get; set; }
        public Nullable<decimal> PDV { get; set; }
        public Nullable<decimal> ZaPlacanje { get; set; }
    
        public virtual NP NP { get; set; }
        public virtual OdgovorneOsobe OdgovorneOsobe { get; set; }
        public virtual Posta Posta { get; set; }
        public virtual Status Status { get; set; }
        public virtual Subjekat Subjekat { get; set; }
        public virtual Subjekat Subjekat1 { get; set; }
        public virtual Valuta Valuta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PredracunStavke> PredracunStavkes { get; set; }
    }
}
