using AutoMapper;
using DesafioFullstack.DTOs;
using DesafioFullstack.Entity;
using DesafioFullstack.Request;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Workshop, WorkshopDTO>();
        CreateMap<WorkshopDTO, Workshop>();
        CreateMap<CollaboratorDTO, Collaborator>();
        CreateMap<Collaborator, CollaboratorDTO>();
        CreateMap<CreateWorkshopRequest, Workshop>();
        CreateMap<CreateCollaboratorRequest, Collaborator>();
        CreateMap<UpdateCollaboratorRequest, Collaborator>();
        CreateMap<UpdateWorkshopRequest, Workshop>();
    }
}