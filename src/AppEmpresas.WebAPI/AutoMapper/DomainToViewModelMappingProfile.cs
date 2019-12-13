using AutoMapper;
using AppEmpresas.Domain.Entities;
using AppEmpresas.WebAPI.ViewModels;

namespace AppEmpresas.WebAPI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Enterprise, EnterpriseViewModel>()
                .ForMember(evm => evm.EnterpriseType, opt => opt.MapFrom(e => e.EnterpriseType))
                .ForAllMembers(opt => opt.Ignore());

            CreateMap<EnterpriseType, EnterpriseViewModel>();
        }
    }
}