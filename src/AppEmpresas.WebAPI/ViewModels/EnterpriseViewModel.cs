using System;
using System.ComponentModel.DataAnnotations;

namespace AppEmpresas.WebAPI.ViewModels
{
    public class EnterpriseViewModel
    {
        [Key]
        [Display(Name = "id")]
        public int Id { get; set; }
        [Display(Name = "email_enterprise")]
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string Phone { get; set; }
        [Display(Name = "own_enterprise")]
        public bool OwnEnterprise { get; set; }
        [Display(Name = "enterprise_name")]
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Value { get; set; }
        public decimal Shares { get; private set; }
        [Display(Name = "share_price")]
        public decimal SharePrice { get; private set; }
        [Display(Name = "own_shares")]
        public decimal OwnShares { get; private set; }
        public int EnterpriseTypeId { get; set; }
        [Display(Name = "enterprise_type")]
        public virtual EnterpriseViewModel EnterpriseType { get; set; }
    }
}