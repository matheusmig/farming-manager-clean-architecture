using System.ComponentModel.DataAnnotations;

namespace WebApi.UseCases.V1.Farms.RegisterFarm
{
    public class FarmFindAllPaginatedRequest
    {
        [Required]
        public int Top { get; set; }

        [Required]
        public int Skip { get; set; }
    }
}
