using AppEmpresas.Core.Data;
using AppEmpresas.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppEmpresas.Domain.Interfaces
{
    public interface IEnterpriseRepository : IRepository<Enterprise>
    {
        Task<IEnumerable<Enterprise>> GetAll();
        Task<Enterprise> GetById(int id);
        
        Task<IEnumerable<Enterprise>> GetByType(int enterpriseTypeId);
        Task<IEnumerable<Enterprise>> Filter(int? enterprise_types, string name);
        Task<IEnumerable<EnterpriseType>> GetTypes();
        
        void Adicionar(Enterprise enterprise);
        void Atualizar(Enterprise enterprise);

        void AdicionarType(EnterpriseType type);
        void AtualizarType(EnterpriseType type);
    }
}