using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using urbancompany_salon.Data;
using urbancompany_salon.Models;

namespace urbancompany_salon.Services
{
    public interface ISalonServiceRepository
    {
        Task<IEnumerable<SalonService>> GetAllServicesAsync();
        Task<SalonService> GetServiceByIdAsync(int id);
        Task AddServiceAsync(SalonService service);
        Task UpdateServiceAsync(SalonService service);
        Task DeleteServiceAsync(int id);
    }

    public class SalonServiceRepository : ISalonServiceRepository
    {
        private readonly ApplicationDbContext _context;

        public SalonServiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SalonService>> GetAllServicesAsync()
        {
            return await _context.SalonServices.ToListAsync();
        }

        public async Task<SalonService> GetServiceByIdAsync(int id)
        {
            return await _context.SalonServices.FindAsync(id);
        }

        public async Task AddServiceAsync(SalonService service)
        {
            _context.SalonServices.Add(service);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateServiceAsync(SalonService service)
        {
            _context.SalonServices.Update(service);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteServiceAsync(int id)
        {
            var service = await _context.SalonServices.FindAsync(id);
            if (service != null)
            {
                _context.SalonServices.Remove(service);
                await _context.SaveChangesAsync();
            }
        }
    }
}