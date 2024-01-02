using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace apitask.Shared.Models
{
    

    public class Remarks
    {  [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your remarks.")]
        public string UserRemarks { get; set; }

        public int GameId { get; set; }
    }

}
