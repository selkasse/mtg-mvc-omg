using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTG_MVC_OMG.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("Preferred Color")]
        public int PreferredColorId { get; set; }
        public string PreferredColor { get; set;  }

        [Required]
        [DisplayName("Preferred Format")]
        public int PreferredFormatId{ get; set; }
        public string PreferredFormat { get; set; }

      /* 
        public async Task GetTaskAsync()
        {
            
        }
*/
    }
}
