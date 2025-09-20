using DesafioFullstack.Entity;

namespace DesafioFullstack.Interfaces
{
    public interface IAttendanceRepository
    {
        Task<List<Collaborator>>  GetByGuid(Guid guid);
    }
}