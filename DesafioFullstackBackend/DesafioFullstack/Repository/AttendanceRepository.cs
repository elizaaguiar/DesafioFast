using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFullstack.AppDbContext;
using DesafioFullstack.Entity;
using DesafioFullstack.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesafioFullstack.Repository
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly DbContexto _context;
        public AttendanceRepository(DbContexto context)
        {
            _context = context;
        }

        public async Task<List<Collaborator>> GetByGuid(Guid workshopGuid)
        {
            return await _context.Attendance
                .Where(a => a.Workshop.Guid == workshopGuid)
                .Select(a => a.Collaborator)
                .ToListAsync();
        }
    }
}