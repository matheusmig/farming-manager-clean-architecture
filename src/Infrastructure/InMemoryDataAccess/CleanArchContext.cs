using Domain.Farms.ValueObjects;
using Infrastructure.InMemoryDataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace Infrastructure.InMemoryDataAccess
{
    public sealed class CleanArchContext
    {

        public CleanArchContext()
        {
            Farms = new Collection<Farm>();

            Farms.Add(new Farm(
                "Fazenda Azul",
                new PositiveDecimal(89.9m),
                new InscricaoEstadual("RS", "9352712655")));

            Farms.Add(new Farm(
                "Fazenda Verde",
                new PositiveDecimal(44.9m),
                new InscricaoEstadual("RS", "2171632571")));

            Farms.Add(new Farm(
                "Fazenda Amarela",
                new PositiveDecimal(150),
                new InscricaoEstadual("RS", "1354743374")));

            Farms.Add(new Farm(
                "Fazenda Branca",
                new PositiveDecimal(77.7m),
                new InscricaoEstadual("RS", "8160526812")));

        }

        public Collection<Farm> Farms { get; set; }
    }
}
