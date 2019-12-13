using AppEmpresas.Core.DomainObjects;

namespace AppEmpresas.Domain.Entities
{
    public class Enterprise : Entity, IAggregateRoot
    {
        public string Email { get; private set; }
        public string Facebook { get; private set; }
        public string Twitter { get; private set; }
        public string Linkedin { get; private set; }
        public string Phone { get; private set; }
        public bool OwnEnterprise { get; private set; }
        public string Name { get; private set; }
        public string Photo { get; private set; }
        public string Description { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public int Value { get; private set; }
        public decimal Shares { get; private set; }
        public decimal SharePrice { get; private set; }
        public decimal OwnShares { get; private set; }
        public int EnterpriseTypeId { get; private set; }

        public virtual EnterpriseType EnterpriseType { get; set; }
        protected Enterprise() { }

        public Enterprise(
            string email,
            string facebook,
            string twitter,
            string linkedin,
            string phone,
            bool ownEnterprise,
            string name,
            string photo,
            string description,
            string city,
            string country,
            int value,
            decimal shares,
            decimal sharePrice,
            decimal ownShares,
            int enterpriseTypeId
            )
        {
            Email = email;
            Facebook = facebook;
            Twitter = twitter;
            Linkedin = linkedin;
            Phone = phone;
            OwnEnterprise = ownEnterprise;
            Name = name;
            Photo = photo;
            Description = description;
            City = city;
            Country = country;
            Value = value;
            Shares = shares;
            SharePrice = sharePrice;
            OwnShares = ownShares;
            EnterpriseTypeId = enterpriseTypeId;
        }
    }
}