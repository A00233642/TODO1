using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace TODO1.ViewModels
{
    public class List
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 1)]
        public string Name { get; set; }

        public bool Done { get; set; }

        public DateTime RegisterDate { get; set; } = DateTime.Now;
    }
}
