//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccessoriesIS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accessories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accessories()
        {
            this.Ordering_accessories = new HashSet<Ordering_accessories>();
        }
    
        public int Id_accessories { get; set; }
        public string View_accessories { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public bool Availability_accessories { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordering_accessories> Ordering_accessories { get; set; }
    }
}