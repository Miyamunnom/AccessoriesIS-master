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
    
    public partial class Performer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Performer()
        {
            this.Implementation_order = new HashSet<Implementation_order>();
        }
    
        public string Full_name_performer { get; set; }
        public int Experience { get; set; }
        public string Education { get; set; }
        public int Number_perfomer { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        public virtual Authorization Authorization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Implementation_order> Implementation_order { get; set; }
    }
}