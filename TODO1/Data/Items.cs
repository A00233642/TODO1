using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TODO1.Data
{
    public class Items
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 1)]  
        public string Name{ get; set; }

        public bool Done { get; set; }

        public DateTime RegisterDate { get; set; } = DateTime.Now;

    }
}
