using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure shield entity to domain shield entity
/// </summary>
public class ShieldEntityMapper
{
    public Shield Map(ShieldEntity infrastructureShield)
    {
        return new Shield
        {
            Id = infrastructureShield.Id,
            Name = infrastructureShield.Name,
            Job = infrastructureShield.Job,
            Defense = infrastructureShield.Defense,
            Evasion = infrastructureShield.Evasion,
            SpritePath = infrastructureShield.SpritePath
        };
    }
}