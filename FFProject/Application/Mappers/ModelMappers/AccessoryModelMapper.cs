using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain accessory entity to accessory model entity
/// </summary>
public class AccessoryModelMapper
{
    public AccessoryModel Map(Accessory accessory)
    {
        return new AccessoryModel
        {
            Id = accessory.Id,
            Name = accessory.Name,
            Evasion = accessory.Evasion,
            Defense = accessory.Defense,
            SpritePath = accessory.SpritePath
        };
    }
}