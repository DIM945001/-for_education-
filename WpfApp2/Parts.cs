//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parts
    {
        public int PartID { get; set; }
        public string PartName { get; set; }
        public string PartManufacturer { get; set; }
        public string Car { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<decimal> PartCost { get; set; }
        public string CarModel { get; set; }
        public string img { get; set; }
        public Nullable<int> CategoryID { get; set; }
    
        public virtual PartCategory PartCategory { get; set; }
    }
}
