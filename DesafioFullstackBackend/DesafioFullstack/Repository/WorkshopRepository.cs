using System.Threading.Tasks;
using DesafioFullstack.AppDbContext;
using DesafioFullstack.Entity;
using DesafioFullstack.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesafioFullstack.Repository
{
    public class WorkshopRepository : IWorkshopRepository
    {
        private readonly DbContexto _context;
        private static readonly List<Workshop> _workshops = new List<Workshop>();
        public WorkshopRepository(DbContexto context)
        {
            _context = context;
        }
        public void DeleteWorkshop(Workshop workshop)
        {
            _context.Workshop.Remove(workshop);
            _context.SaveChanges();
        }
        public async Task<List<Workshop>> GetAll()
        {
            return await _context.Workshop.ToListAsync();
        }

        public Workshop? SearchWorkshopById(int id)
        {
            return _context.Workshop.Where(w => w.Id == id).FirstOrDefault();
        }

        public void Update(Workshop workshop)
        {
            workshop.UpdatedAt = DateTime.UtcNow;
            _context.Workshop.Update(workshop);
            _context.SaveChanges();
        }
        public void Delete(Workshop workshop)
        {
            workshop.RemovedAt = DateTime.UtcNow;
            _context.Workshop.Update(workshop);
            _context.SaveChanges();
        }
        public void Create(Workshop workshop)
        {
            _context.Workshop.Add(workshop);
            _context.SaveChanges();
        }
        public async Task<Workshop> GetByGuid(Guid guid)
        {
            return await _context.Workshop.FirstOrDefaultAsync(w => w.Guid == guid && w.RemovedAt == null);
        }
    }
}