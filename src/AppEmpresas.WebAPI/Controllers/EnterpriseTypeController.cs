using AppEmpresas.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace AppEmpresas.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/enterprise_types")]
    public class EnterpriseTypeController : ControllerBase
    {
        private readonly IEnterpriseRepository _enterpriseRepository;

        public EnterpriseTypeController(IEnterpriseRepository enterpriseRepository)
        {
            _enterpriseRepository = enterpriseRepository;
        }

        [HttpGet]
        [Route("")]
        public async Task<object> Get()
        {
            var dados = await _enterpriseRepository.GetTypes();
            return new
            {
                enterprise_types = dados.Select(x => new { id = x.Id, enterprise_type_name = x.Name }),
                success = true
            };
        }
    }
}