using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DesafioFullstack.Entity;
using DesafioFullstack.Request;
using DesafioFullstack.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DesafioFullstack.Controllers
{
    [ApiController]
    [Route("api/collaborators")]
    public class CollaboratorController : ControllerBase
    {
        private readonly CollaboratorService _collaborator;

        public CollaboratorController(CollaboratorService collaborator, IConfiguration configuration)
        {
            _collaborator = collaborator;
            Configuration = configuration;
            var builder = WebApplication.CreateBuilder();
            key = builder.Configuration["Jwt:Key"];
        }
        private string key;
        public IConfiguration Configuration { get; set; } = default!;

        [HttpGet("{guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetWorkshopByGuid(Guid guid)
        {
            return Ok(await _collaborator.GetByGuid(guid));
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Create(CreateCollaboratorRequest request)
        {
            _collaborator.Create(request);
            return Ok("Colaborador registrado com sucesso");
        }
        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> Update(UpdateCollaboratorRequest request)
        {
            await _collaborator.Update(request);
            return Ok("Colaborador atualizado com sucesso.");
        }
        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(Guid guid)
        {
            await _collaborator.Delete(guid);
            return Ok("Colaborador removido com sucesso!");
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllCollaborators()
        {
            return Ok(await _collaborator.GetAll());
        }
        [HttpGet("needAuth")]
        [Authorize]
        public IActionResult NeedAuth()
        {
            return Ok();
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginCollaborator(LoginRequest loginRequest)
        {
            var collaborator = _collaborator.GetByUsernameAndPassword(loginRequest);

            if (collaborator == null)
            {
                return Unauthorized("Usuário ou senha inválidos.");
            }
            var token = GenerateJwtToken(await collaborator);
            return Ok(new { token = token });
        }
        private string GenerateJwtToken(Collaborator collaborator)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new InvalidOperationException("A chave não existe");
            }
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("Name", collaborator.Name),
            };
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

