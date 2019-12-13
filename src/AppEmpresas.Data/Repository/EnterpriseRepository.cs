using Microsoft.EntityFrameworkCore;
using AppEmpresas.Domain.Entities;
using AppEmpresas.Core.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppEmpresas.Domain.Interfaces;

namespace AppEmpresas.Data.Repository
{
    public class EnterpriseRepository : IEnterpriseRepository
    {
        private readonly AppEmpresasDbContext _context;

        public EnterpriseRepository(AppEmpresasDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Enterprise enterprise)
        {
            _context.Enterprises.Add(enterprise);
        }

        public void AdicionarType(EnterpriseType type)
        {
            _context.EnterpriseTypes.Add(type);
        }

        public void Atualizar(Enterprise enterprise)
        {
            _context.Enterprises.Update(enterprise);
        }

        public void AtualizarType(EnterpriseType type)
        {
            _context.EnterpriseTypes.Update(type);
        }

        public async Task<IEnumerable<EnterpriseType>> GetTypes()
        {
            return await _context.EnterpriseTypes.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Enterprise>> GetByType(int enterpriseTypeId)
        {
            return await _context.Enterprises.AsNoTracking().Include(e => e.EnterpriseType).Where(t => t.EnterpriseType.Id == enterpriseTypeId).ToListAsync();
        }

        public async Task<Enterprise> GetById(int id)
        {
            return await _context.Enterprises.AsNoTracking().Include(e => e.EnterpriseType).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Enterprise>> GetAll()
        {
            return await _context.Enterprises.AsNoTracking().ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<Enterprise>> Filter(int? enterpriseTypeId, string name)
        {
            return await _context.Enterprises.AsNoTracking().Include(e => e.EnterpriseType)
                .Where(e => e.EnterpriseTypeId.Equals(enterpriseTypeId != null ? enterpriseTypeId : e.EnterpriseTypeId)
                        && e.Name.ToUpper().Contains(name != null ? name.ToUpper() : e.Name.ToUpper())).ToListAsync();
        }
    }
}