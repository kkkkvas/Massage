//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp5666
{
    using System;
    using System.Collections.Generic;
    
    public partial class Massage
    {
        public int massageID { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string status { get; set; }
        public Nullable<int> reservationID { get; set; }
    
        public virtual Reservation Reservation { get; set; }
    }
}
