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
    
    public partial class RoomTypes
    {
        public RoomTypes()
        {
            this.Rooms = new HashSet<Rooms>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
