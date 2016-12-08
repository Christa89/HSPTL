using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelData.PartialClass;

namespace ModelData
{
    [MetadataType(typeof(User_AccountMetadata))]
    public partial  class User_Account{}

    [MetadataType(typeof(Med_quantity_typeMetadata))]
    public partial class Med_quantity_type { }
 
}
