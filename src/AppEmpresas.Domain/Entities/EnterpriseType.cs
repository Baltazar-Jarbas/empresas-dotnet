using AppEmpresas.Core.DomainObjects;
using System.Collections.Generic;

namespace AppEmpresas.Domain.Entities
{
    public class EnterpriseType : Entity
    {
        public string Name { get; private set; }
        public virtual ICollection<Enterprise> Enterprises { get; set; }

        protected EnterpriseType() { }

        public EnterpriseType(string name)
        {
            Name = name;
        }
    }
}