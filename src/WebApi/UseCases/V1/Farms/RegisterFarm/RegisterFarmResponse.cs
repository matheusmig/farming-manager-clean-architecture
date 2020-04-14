using Domain.Farms.Entities;
using System.ComponentModel.DataAnnotations;

namespace WebApi.UseCases.V1.Farms.RegisterFarm
{
    public sealed class RegisterFarmResponse
    {
        public RegisterFarmResponse(IFarm farm)
        {
            Id = farm.Id;
            Name = farm.Name;
        }

        [Required]
        public long Id { get; }

        [Required]
        public string Name { get; }
    }   
}
