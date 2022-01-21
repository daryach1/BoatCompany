//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoatCompanyCherc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Boat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boat()
        {
            this.BoatAccessory = new HashSet<BoatAccessory>();
            this.Order = new HashSet<Order>();
        }
    
        public int id { get; set; }
        public string model { get; set; }
        public Nullable<int> boatType_id { get; set; }
        public Nullable<int> NumberOfRower { get; set; }
        public Nullable<bool> Mast { get; set; }
        public Nullable<int> Color_id { get; set; }
        public Nullable<int> wood_id { get; set; }
        public decimal basePrice { get; set; }
        public Nullable<decimal> VAT { get; set; }
    
        public virtual BoatType BoatType { get; set; }
        public virtual Color Color { get; set; }
        public virtual Wood Wood { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoatAccessory> BoatAccessory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
