#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using deliverycart.Data;
using deliverycart.Models;

namespace deliverycart.Pages_Orders
{
    public class DetailsModel : PageModel
    {
        private readonly deliverycart.Data.Assignment3XTestsContext _context;

        public DetailsModel(deliverycart.Data.Assignment3XTestsContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order
                .Include(o => o.Customer)
                .Include(o => o.Item).FirstOrDefaultAsync(m => m.OrderID == id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
