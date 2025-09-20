using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFullstack.Entity;

namespace DesafioFullstack.Interfaces
{
    public interface ICollaboratorRepository
    {
        void Create(Collaborator collaborator);
        void Delete(Collaborator collaborator);
        void Update(Collaborator collaborator);
        Collaborator? SearchCollaborator(string Name);        
        Task<List<Collaborator>> GetAll();
        Task<Collaborator> GetByGuid(Guid guid);
    }
}