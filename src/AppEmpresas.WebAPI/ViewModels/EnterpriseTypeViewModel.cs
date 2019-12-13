using System.ComponentModel.DataAnnotations;

namespace AppEmpresas.WebAPI.ViewModels
{
    public class EnterpriseTypeViewModel
    {
        [Key]
        [Display(Name = "id")]
        public int Id { get; set; }

        [Display(Name = "enterprise_type_name")]
        public string Name { get; set; }
    }
}
