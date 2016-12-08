using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ModelData.PartialClass
{
   public partial  class Med_quantity_typeMetadata
    {
        public int Med_quan_typeId { get; set; }

       [Required()]
       [Display(Name ="Quantity Type")]
        public string Med_quan_type { get; set; }
       [Display(Name = "Quantity")]
        public Nullable<decimal> Med_quantity { get; set; }
    }
}
