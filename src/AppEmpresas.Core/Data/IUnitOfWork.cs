using System.Threading.Tasks;

namespace AppEmpresas.Core.Data
{
    public interface IUnitOfWork 
    {
        Task<bool> Commit();
    }
}
