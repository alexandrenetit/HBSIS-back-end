using AutoMapper;
using HBSIS.Domain.Entities;
using HBSIS.Services.Api.ViewModel;

namespace HBSIS.Services.Api.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
        }
    }
}