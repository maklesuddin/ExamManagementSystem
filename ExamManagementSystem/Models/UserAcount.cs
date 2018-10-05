﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class UserAcount
    {
       [Key]
       public int  UserId { get; set; }
       [Required(ErrorMessage = "First Name is Required")]
       public string FirstName { get; set; }
       [Required(ErrorMessage = "Last Name is required")]
       public string LastName { get; set; }
       [Required(ErrorMessage = "Eamil is required")]
       [DataType(DataType.EmailAddress)]
       public string Email { get; set; }
       [Required(ErrorMessage = "UesrName is Required")]
       public string UserName { get; set; }
       [Required(ErrorMessage = "UserName is required")]
       [DataType(DataType.Password)]
       public string Password { get; set; }
       [Compare("Password",ErrorMessage = "please confirm your password ")]
       [DataType(DataType.Password)]
       public string ConfirmPassword { get; set; }

    }
}
