using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudWithRazorPages.DAL;
using CrudWithRazorPages.Models;

namespace CrudWithRazorPages.Pages.ProductMaster
{
    public class IndexModel : PageModel
    {
        private readonly CrudWithRazorPages.DAL.AppDbContext _context;

        public IndexModel(CrudWithRazorPages.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
