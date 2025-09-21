
using DesafioFullstack.Services;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
        public async Task<IActionResult> GetAll(Guid workshopGuid)
        {
            return Ok( await _attendance.Get(workshopGuid));
        }
    }
}