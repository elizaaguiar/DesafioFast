using System.Threading.Tasks;
using DesafioFullstack.Entity;
using DesafioFullstack.Interfaces;
using DesafioFullstack.Request;
using DesafioFullstack.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesafioFullstack.Controllers
{
    [ApiController]
    [Route("api/collaborators")]
    public class CollaboratorController : ControllerBase
    {
        private readonly CollaboratorService _collaborator;

        public CollaboratorController(CollaboratorService collaborator)
        {
            _collaborator = collaborator;
        }
        [HttpGet("{guid}")]
        public async Task<IActionResult> GetWorkshopByGuid(Guid guid)
        {
            return Ok(await _collaborator.GetByGuid(guid));
        }
        [HttpPost]
        public IActionResult Create(CreateCollaboratorRequest request)
        {
            _collaborator.Create(request);
            return Ok("Colaborador registrado com sucesso");
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateCollaboratorRequest request)
        {
            await _collaborator.Update(request);
            return Ok("Colaborador atualizado com sucesso.");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid guid)
        {
            await _collaborator.Delete(guid);
            return Ok("Colaborador removido com sucesso!");
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCollaborators()
        {    
            return Ok(await _collaborator.GetAll());
        }
    }
}