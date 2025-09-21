
using DesafioFullstack.Request;
using DesafioFullstack.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DesafioFullstack.Controllers
{
    [ApiController]
    [Route("api/workshops")]
    public class WorkshopController : ControllerBase
    {
        private readonly WorkshopService _workshop;

        public WorkshopController(WorkshopService workshop)
        {
            _workshop = workshop;
        }
        [HttpGet("{guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetWorkshopByGuid(Guid guid)
        {
            return Ok(await _workshop.GetByGuid(guid));
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult RegisterWorkshop(CreateWorkshopRequest request)
        {
            _workshop.Create(request);
            return Ok("Colaborador registrado com sucesso");
        }
        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> Update(UpdateWorkshopRequest request)
        {
            await _workshop.Update(request);
            return Ok("Workshop atualizado com sucesso.");
        }
        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(Guid guid)
        {
            await _workshop.Delete(guid);
            return Ok("Workshop removido com sucesso!");
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllWorkshops()
        {
            return Ok(await _workshop.GetAll());
        }
    }
}