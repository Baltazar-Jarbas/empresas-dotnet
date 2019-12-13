using AppEmpresas.Core.DomainObjects;
using System;

namespace AppEmpresas.Core.Data
{
    public interface IRepository<T> : IDisposable where T: IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}