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
    
    public partial class BoatAccessory
    {
        public int id { get; set; }
        public Nullable<int> accessory_id { get; set; }
        public Nullable<int> boat_id { get; set; }
    
        public virtual Accessory Accessory { get; set; }
        public virtual Boat Boat { get; set; }
    }
}
