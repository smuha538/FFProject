using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure accessory entity to domain accessory entity
/// </summary>
public class AccessoryEntityMapper
{
    public Accessory Map(AccessoryEntity infrastructureAccessory)
    {
        return new Accessory
        {
            Id = infrastructureAccessory.Id,
            Name = infrastructureAccessory.Name,
            Evasion = infrastructureAccessory.Evasion,
            Defense = infrastructureAccessory.Defense,
            SpritePath = infrastructureAccessory.SpritePath,
        };
    }
}