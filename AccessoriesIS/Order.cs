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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Implementation_order = new HashSet<Implementation_order>();
            this.Ordering_accessories = new HashSet<Ordering_accessories>();
        }
    
        public int Id_order { get; set; }
        public string Full_name_client { get; set; }
        public System.DateTime Date { get; set; }
        public bool Order_status { get; set; }
        public int Id__construction { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Construction Construction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Implementation_order> Implementation_order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordering_accessories> Ordering_accessories { get; set; }
    }
}