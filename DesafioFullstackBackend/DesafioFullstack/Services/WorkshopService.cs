using System.Threading.Tasks;
using AutoMapper;
using DesafioFullstack.DTOs;
using DesafioFullstack.Entity;
using DesafioFullstack.Interfaces;
using DesafioFullstack.Request;

namespace DesafioFullstack.Services
{
    public class WorkshopService
    {
        private readonly IWorkshopRepository _workshopRepository;
        private readonly IMapper _mapper;
        public WorkshopService(IWorkshopRepository workshopRepository, IMapper mapper)
        {
            _workshopRepository = workshopRepository;
            _mapper = mapper;
        }

        public void Create(CreateWorkshopRequest request)
        {
            if (request.ExecutionDate.Date < DateTime.UtcNow.Date)
            {
                throw new Exception("A data deve ser maior que a data atual.");
            }
            var workshop = _mapper.Map<Workshop>(request);
            _workshopRepository.Create(workshop);
        }
        public async Task Update(UpdateWorkshopRequest request)
        {
            var workshop = await _workshopRepository.GetByGuid(request.Guid);
            if (workshop == null)
            {
                throw new Exception("O Workshop não existe.");
            }
            workshop.Name = request.Name;
            workshop.Description = request.Description;
            _workshopRepository.Update(workshop);

        }
        public async Task Delete(Guid guid)
        {
            var workshop = await _workshopRepository.GetByGuid(guid);

            if (workshop == null)
            {
                throw new Exception("O Workshop não foi encontrado.");
            }
            _workshopRepository.Delete(workshop);
        }
        public async Task<WorkshopDTO> GetByGuid(Guid guid)
        {
            var workshop = await _workshopRepository.GetByGuid(guid);
            return _mapper.Map<WorkshopDTO>(workshop);
        }
        public async Task<List<WorkshopDTO>> GetAll()
        { 
            var workshops = await _workshopRepository.GetAll();
            var activeWorkshops = workshops.Where(w => w.RemovedAt == null ).ToList();
            return _mapper.Map<List<WorkshopDTO>>(activeWorkshops);
        }
    }
}