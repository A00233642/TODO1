using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TODO1.Data.Context;
using TODO1.ViewModels;
using TODO1.Data;

namespace TODO1.Pages
{
    public class IndexModel : PageModel
    {

        StoreContext _context;

        [FromQuery]
        public Items Items { get; set; }

        [FromQuery]
        public Items UpdateItems { get; set; }


        public IndexModel(StoreContext context)
        {
            _context = context;
        }

        public void OnGet()
         {
           
        }

        [FromQuery]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Done { get; set; }

        public DateTime RegisterDate { get; set; } = DateTime.Now;

    

        public void OnPost()

        {

          
    }

      


    }

  
}

