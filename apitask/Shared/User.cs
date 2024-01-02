using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace apitask.Shared.Models
{
        public class User
    {
            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "Please enter the username.")]
            [StringLength(50, ErrorMessage = "Username must be less than 50 characters.")]
            public string Username { get; set; }

            [EmailAddress(ErrorMessage = "Invalid email address.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Please enter your age.")]
            public int Age { get; set; }
        }
    

}
