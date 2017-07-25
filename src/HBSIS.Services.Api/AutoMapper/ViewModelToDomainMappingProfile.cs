using AutoMapper;
using HBSIS.Domain.Entities;
using HBSIS.Services.Api.ViewModel;

namespace HBSIS.Services.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>()
                .ConstructUsing(c => new Cliente(c.Id, c.Nome, c.CpfCnpj, c.Telefone));
        }
    }
}