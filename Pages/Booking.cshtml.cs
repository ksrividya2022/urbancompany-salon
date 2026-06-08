using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using urbancompany_salon.Models;
using urbancompany_salon.Data;

namespace urbancompany_salon.Pages
{
    public class BookingModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public BookingModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Booking Booking { get; set; }

        public void OnGet()
        {
            // Initialize Booking object or load necessary data for the booking page
            Booking = new Booking();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bookings.Add(Booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index"); // Redirect to the Index page after successful booking
        }
    }
}