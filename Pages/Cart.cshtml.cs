using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using urbancompany_salon.Data;
using urbancompany_salon.Models;

namespace urbancompany_salon.Pages
{
    public class CartModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CartModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CartItem> CartItems { get; set; }
        public decimal TotalPrice { get; set; }

        public void OnGet()
        {
            // Retrieve cart items from the database with service details
            CartItems = _context.CartItems
                .Include(ci => ci.Service)
                .Where(ci => ci.UserId == User.Identity.Name)
                .ToList();
            TotalPrice = CartItems.Sum(ci => ci.Service?.Price * ci.Quantity ?? 0);
        }

        public IActionResult OnPostRemove(int id)
        {
            var item = _context.CartItems.Find(id);
            if (item != null)
            {
                _context.CartItems.Remove(item);
                _context.SaveChanges();
            }
            return RedirectToPage();
        }

        public IActionResult OnPostCheckout()
        {
            // Implement checkout logic here
            return RedirectToPage("/Booking");
        }
    }
}