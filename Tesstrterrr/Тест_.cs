//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tesstrterrr
{
    using System;
    using System.Collections.Generic;
    
    public partial class Тест_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Тест_()
        {
            this.Вопрос_ = new HashSet<Вопрос_>();
            this.История_ = new HashSet<История_>();
        }
    
        public int Номер { get; set; }
        public string Название { get; set; }
        public Nullable<int> Номер_дисциплины { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Вопрос_> Вопрос_ { get; set; }
        public virtual Дисциплины_ Дисциплины_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<История_> История_ { get; set; }
    }
}
