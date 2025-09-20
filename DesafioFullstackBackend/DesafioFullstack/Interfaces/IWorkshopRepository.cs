using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFullstack.DTOs;
using DesafioFullstack.Entity;

namespace DesafioFullstack.Interfaces
{
    public interface IWorkshopRepository
    {
        void Create(Workshop workshop);
        void Update(Workshop workshop);
        void Delete(Workshop workshop);
        Workshop? SearchWorkshopById(int id);
        Task<List<Workshop>> GetAll();
        Task<Workshop> GetByGuid(Guid guid);
    }
}