using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DesafioFullstack.DTOs;
using DesafioFullstack.Entity;
using DesafioFullstack.Interfaces;

namespace DesafioFullstack.Services
{
    public class AttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepository;
        private readonly IMapper _mapper;        
        public AttendanceService(IAttendanceRepository attendanceRepository, IMapper mapper)
        {
            _attendanceRepository = attendanceRepository;
            _mapper = mapper;
        }
        public async Task<List<CollaboratorDTO>> Get(Guid workshopGuid)
        {
            var collaboratorsList = await _attendanceRepository.GetByGuid(workshopGuid);
            return _mapper.Map<List<CollaboratorDTO>>(collaboratorsList);
        }
    }
}