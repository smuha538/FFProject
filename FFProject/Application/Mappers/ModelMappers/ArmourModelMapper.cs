using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain armour entity to armour model entity
/// </summary>
public class ArmourModelMapper
{
    public ArmourModel Map(Armour armour)
    {
        return new ArmourModel
        {
            Id = armour.Id,
            Name = armour.Name,
            Job = armour.Job,
            Defense = armour.Defense,
            Evasion = armour.Evasion,
            SpritePath = armour.SpritePath
        };
    }
}