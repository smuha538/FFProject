using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain shield entity to shield model entity
/// </summary>
public class ShieldModelMapper
{
    public ShieldModel Map(Shield shield)
    {
        return new ShieldModel
        {
            Id = shield.Id,
            Name = shield.Name,
            Job = shield.Job,
            Defense = shield.Defense,
            Evasion = shield.Evasion,
            SpritePath = shield.SpritePath
        };
    }
}