using System.ComponentModel.DataAnnotations;

namespace WebApi.UseCases.V1.Farms.RegisterFarm
{
    public class RegisterFarmRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Area { get; set; }

        [Required]
        public string InscricaoEstadualNumber { get; set; }

        [Required]
        public string InscricaoEstadualState { get; set; }
    }
}
