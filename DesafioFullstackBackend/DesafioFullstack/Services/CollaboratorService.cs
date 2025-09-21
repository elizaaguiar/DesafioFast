using AutoMapper;
using DesafioFullstack.DTOs;
using DesafioFullstack.Entity;
using DesafioFullstack.Interfaces;
using DesafioFullstack.Request;

namespace DesafioFullstack.Services
{
    public class CollaboratorService
    {
        private readonly ICollaboratorRepository _collaboratorRepository;
        private readonly IMapper _mapper;
        public CollaboratorService(ICollaboratorRepository collaboratorRepository, IMapper mapper)
        {
            _collaboratorRepository = collaboratorRepository;
            _mapper = mapper;
        }
        public void Create(CreateCollaboratorRequest request)
        {
            var collaborator = _mapper.Map<Collaborator>(request);
            _collaboratorRepository.Create(collaborator);
        }
        public async Task Update(UpdateCollaboratorRequest request)
        {
            var collaborator = await _collaboratorRepository.GetByGuid(request.Guid);
            if (collaborator == null)
            {
                throw new Exception("O Colaborador não existe.");
            }
            collaborator.Name = request.Name;
            _collaboratorRepository.Update(collaborator);

        }
        public async Task Delete(Guid guid)
        {
            var collaborator = await _collaboratorRepository.GetByGuid(guid);

            if (collaborator == null)
            {
                throw new Exception("O Colaborador não foi encontrado.");
            }
            _collaboratorRepository.Delete(collaborator);

        }
        public async Task<CollaboratorDTO> GetByGuid(Guid guid)
        {
            var collaborator = await _collaboratorRepository.GetByGuid(guid);
            return _mapper.Map<CollaboratorDTO>(collaborator);
        }
        public async Task<List<CollaboratorDTO>> GetAll()
        {
            var collaborator = await _collaboratorRepository.GetAll();
            return _mapper.Map<List<CollaboratorDTO>>(collaborator);
        }
        public async Task<Collaborator> GetByUsernameAndPassword(LoginRequest loginRequest)
        {
            var collaborator = await _collaboratorRepository.GetByUsernameAndPassword(loginRequest);
            return _mapper.Map<Collaborator>(collaborator);
        }
    }
}