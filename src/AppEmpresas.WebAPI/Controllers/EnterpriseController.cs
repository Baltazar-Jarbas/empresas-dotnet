using System.Linq;
using System.Threading.Tasks;
using AppEmpresas.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppEmpresas.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/enterprises")]
    public class EnterpriseController : ControllerBase
    {
        private readonly IEnterpriseRepository _enterpriseRepository;

        public EnterpriseController(IEnterpriseRepository enterpriseRepository)
        {
            _enterpriseRepository = enterpriseRepository;
        }

        [HttpGet]
        [Route("")]
        public async Task<object> Get(int? enterprise_types, string name)
        {
            var dados = await _enterpriseRepository.Filter(enterprise_types, name);
            return new { enterprises = dados.Select(x => new {
                id = x.Id,
                email_enterprise = x.Email,
                facebook = x.Facebook,
                twitter = x.Twitter,
                linkedin = x.Linkedin,
                phone = x.Phone,
                own_enterprise = x.OwnEnterprise,
                enterprise_name = x.Name,
                photo = x.Photo,
                description = x.Description,
                city = x.City,
                country = x.Country,
                value = x.Value,
                share_price = x.SharePrice,
                enterprise_type = new {
                    id = x.EnterpriseType.Id,
                    enterprise_type_name = x.EnterpriseType.Name
                }
            })};
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<object> GetById(int id)
        {
            var dados = await _enterpriseRepository.GetById(id);
            if (dados != null)
            {
                return new
                {
                    enterprise = new
                    {
                        id = dados.Id,
                        enterprise_name = dados.Name,
                        description = dados.Description,
                        email_enterprise = dados.Email,
                        dados.Facebook,
                        dados.Twitter,
                        dados.Linkedin,
                        dados.Phone,
                        own_enterprise = dados.OwnEnterprise,
                        dados.Photo,
                        dados.Value,
                        shares = dados.Shares,
                        share_price = dados.SharePrice,
                        own_shares = dados.OwnShares,
                        dados.City,
                        dados.Country,
                        enterprise_type = new
                        {
                            id = dados.EnterpriseType.Id,
                            enterprise_type_name = dados.EnterpriseType.Name
                        }
                    },
                    success = true
                };
            }
            else
            {
                BadRequest();
                return new
                {
                    status = 404,
                    error = "Not Found"
                };
            }
        }
    }
}