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
using Microsoft.EntityFrameworkCore;

namespace TODO1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private StoreContext _context { get; set; }

       
        //StoreContext _context;

        [BindProperty]
        public Items Item { get; set; }

        

        public IEnumerable<Items> Log;


        public IndexModel(ILogger<IndexModel> logger, StoreContext context)
        {
            _logger = logger;
            _context = context;
            

        }

        
       

        public void OnGet()
         {
            if (Item != null && Item.Id > 0)
            {
                Item.Done = true;
                _context.Items.Update(Item);
                _context.SaveChanges();

            }

            Log = _context.Items.ToList();

        }




        public void OnPost()

        {
            if (!String.IsNullOrEmpty(Item.Name))
            {
                _context.Items.Add(Item);
                _context.SaveChanges();
            }

         
            Log = _context.Items.ToList();


        }

       

         
    }

  
}

