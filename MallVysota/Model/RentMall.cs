//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MallVysota.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class RentMall
    {
        public int ID { get; set; }
        public int IDRooms { get; set; }
        public Nullable<int> IDUsers { get; set; }
    
        public virtual Rooms Rooms { get; set; }
        public virtual Users Users { get; set; }
    }
}
