
using DesafioFullstack.AppDbContext;
using DesafioFullstack.Entity;
using DesafioFullstack.Interfaces;
using DesafioFullstack.Request;
using Microsoft.EntityFrameworkCore;

namespace DesafioFullstack.Repository
{
    public class CollaboratorRepository : ICollaboratorRepository
    {
        private readonly DbContexto _context;
        public CollaboratorRepository(DbContexto context)
        {
            _context = context;
        }
        public void Create(string name, int id)
        {
            
            var newCollaborator = new Collaborator
            {
                Name = name,
                Id = id
            };
            _context.Collaborator.Add(newCollaborator);
            _context.SaveChanges();
        }
        public Collaborator? SearchCollaborator(string Name)
        {
            return _context.Collaborator.Where(c => c.Name == Name).FirstOrDefault();
        }
        public void Update(Collaborator collaborator)
        {
            collaborator.UpdatedAt = DateTime.UtcNow;
            _context.Collaborator.Update(collaborator);
            _context.SaveChanges();
        }
        public async Task<List<Collaborator>> GetAll()
        {
            return await _context.Collaborator.Where(c => c.RemovedAt == null).ToListAsync();
        }
        public void Delete(Collaborator collaborator)
        {
            collaborator.RemovedAt = DateTime.UtcNow;
            _context.Collaborator.Update(collaborator);
            _context.SaveChanges();
        }
        public void Create(Collaborator collaborator)
        {
            _context.Collaborator.Add(collaborator);
            _context.SaveChanges();
        }
        public async Task<Collaborator> GetByGuid(Guid guid)
        {
            return await _context.Collaborator.FirstOrDefaultAsync(c => c.Guid == guid && c.RemovedAt == null);
        }

        public async Task<Collaborator> GetByUsernameAndPassword(LoginRequest loginRequest)
        {
            var collaborator = await _context.Collaborator.Where(l => l.Name == loginRequest.Name && l.PasswordHash == loginRequest.Password).FirstOrDefaultAsync();
            return collaborator;
        }
    }
}