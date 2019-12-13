using AutoMapper;
using AppEmpresas.WebAPI.ViewModels;
using AppEmpresas.Domain.Entities;

namespace AppEmpresas.WebAPI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<EnterpriseViewModel, Enterprise>()
                .ConstructUsing(e =>
                    new Enterprise(e.Email,e.Facebook,e.Twitter,e.Linkedin,e.Phone,e.OwnEnterprise,e.Name,e.Photo,e.Description,e.City,e.Country,e.Value,e.Shares,e.SharePrice,e.OwnShares,e.EnterpriseTypeId));

            CreateMap<EnterpriseViewModel, EnterpriseType>()
                .ConstructUsing(t => new EnterpriseType(t.Name));
        }
    }
}