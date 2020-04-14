using Domain.Farms.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.UseCases.V1.Farms.RegisterFarm
{
    public sealed class FarmFindAllPaginatedResponse
    {
        public FarmFindAllPaginatedResponse(IEnumerable<IFarm> farms, long total)
        {
            Total = total;
            Farms = farms;
        }

        [Required]
        public long Total { get; }

        [Required]
        public IEnumerable<IFarm> Farms { get; }
    }   
}
