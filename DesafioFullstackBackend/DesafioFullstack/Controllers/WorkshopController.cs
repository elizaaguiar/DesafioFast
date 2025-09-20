using System.Threading.Tasks;
using DesafioFullstack.DTOs;
using DesafioFullstack.Entity;
using DesafioFullstack.Interfaces;
using DesafioFullstack.Request;
using DesafioFullstack.Services;
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
        public async Task<IActionResult> GetWorkshopByGuid(Guid guid)
        {
            return Ok(await _workshop.GetByGuid(guid));
        }
        [HttpPost]
        public IActionResult RegisterWorkshop(CreateWorkshopRequest request)
        {
            _workshop.Create(request);
            return Ok("Colaborador registrado com sucesso");
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateWorkshopRequest request)
        {
            await _workshop.Update(request);
            return Ok("Workshop atualizado com sucesso.");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid guid)
        {
            await _workshop.Delete(guid);
            return Ok("Workshop removido com sucesso!");
        }
        [HttpGet]
        public async Task<IActionResult> GetAllWorkshops()
        {    
            return Ok(await _workshop.GetAll());
        }
    }
}