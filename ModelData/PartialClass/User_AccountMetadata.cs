using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ModelData
{
  public   class User_AccountMetadata
    {
        [Required(ErrorMessage = "UserName is required.")]
        public string UserName { get; set; }

       
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }


    }
}
