//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CosmeticStore1.Connection
{
    using System;
    using System.Collections.Generic;
    
    public partial class supply_items
    {
        public int supply_item_id { get; set; }
        public Nullable<int> supply_id { get; set; }
        public Nullable<int> product_id { get; set; }
        public int quantity { get; set; }
        public decimal unit_cost { get; set; }
    
        public virtual products products { get; set; }
        public virtual supplies supplies { get; set; }
    }
}
