using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using urbancompany_salon.Models;
using urbancompany_salon.Services;

namespace urbancompany_salon.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ISalonServiceRepository _salonServiceRepository;

        public IndexModel(ISalonServiceRepository salonServiceRepository)
        {
            _salonServiceRepository = salonServiceRepository;
        }

        public IList<SalonService> Services { get; set; }

        public async Task OnGetAsync()
        {
            Services = (IList<SalonService>)await _salonServiceRepository.GetAllServicesAsync();
        }
    }
}