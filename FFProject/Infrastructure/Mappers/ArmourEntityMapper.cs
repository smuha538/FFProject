using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure armour entity to domain armour entity
/// </summary>
public class ArmourEntityMapper
{
    public Armour Map(ArmourEntity infrastructureArmour)
    {
        return new Armour
        {
            Id = infrastructureArmour.Id,
            Name = infrastructureArmour.Name,
            Defense = infrastructureArmour.Defense,
            Evasion = infrastructureArmour.Evasion,
            SpritePath = infrastructureArmour.SpritePath,
            Job = infrastructureArmour.Job
        };
    }
}