using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using urbancompany_salon.Models;
using urbancompany_salon.Services;

namespace urbancompany_salon.Pages
{
    public class ServicesModel : PageModel
    {
        private readonly ISalonServiceRepository _salonServiceRepository;

        public ServicesModel(ISalonServiceRepository salonServiceRepository)
        {
            _salonServiceRepository = salonServiceRepository;
        }

        public IList<SalonService> AvailableServices { get; set; }

        public async Task OnGetAsync()
        {
            AvailableServices = (IList<SalonService>)await _salonServiceRepository.GetAllServicesAsync();
        }
    }
}