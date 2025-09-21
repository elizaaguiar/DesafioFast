using DesafioFullstack.DTOs;
using DesafioFullstack.Entity;
using DesafioFullstack.Request;

namespace DesafioFullstack.Interfaces
{
    public interface ICollaboratorRepository
    {
        void Create(Collaborator collaborator);
        void Delete(Collaborator collaborator);
        void Update(Collaborator collaborator);
        Task<Collaborator> GetByUsernameAndPassword(LoginRequest loginRequest);
        Collaborator? SearchCollaborator(string Name);
        Task<List<Collaborator>> GetAll();
        Task<Collaborator> GetByGuid(Guid guid);
    }
}