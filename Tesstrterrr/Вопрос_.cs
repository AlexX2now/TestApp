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
    
    public partial class Вопрос_
    {
        public int Идентификатор { get; set; }
        public Nullable<int> Номер_теста { get; set; }
        public Nullable<int> Номер_вопроса { get; set; }
        public string Вопрос { get; set; }
        public string Вариант1 { get; set; }
        public string Вариант2 { get; set; }
        public string Вариант3 { get; set; }
        public Nullable<int> Ответ { get; set; }
    
        public virtual Тест_ Тест_ { get; set; }
    }
}
