using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace apitask.Shared.Models
{

    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the game title.")]
        public string GameTitle { get; set; }

        [Required(ErrorMessage = "Please enter the game type.")]
        public string GameType { get; set; }


    }

}
