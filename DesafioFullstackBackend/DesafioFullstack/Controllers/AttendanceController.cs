using System.Threading.Tasks;
using DesafioFullstack.DTOs;
using DesafioFullstack.Entity;
using DesafioFullstack.Interfaces;
using DesafioFullstack.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesafioFullstack.Controllers
{
    [ApiController]
    [Route("api/attendance")]
    public class AttendanceController : ControllerBase
    {
        private readonly AttendanceService _attendance;

        public AttendanceController(AttendanceService attendance)
        {
            _attendance = attendance;
        }
        [HttpGet("{workshopGuid}")]
        public async Task<IActionResult> GetAll(Guid workshopGuid)
        {
            return Ok( await _attendance.Get(workshopGuid));
        }
    }
}