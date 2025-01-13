using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain weapon entity to weapon model entity
/// </summary>
public class WeaponModelMapper
{
    public WeaponModel Map(Weapon weapon)
    {
        return new WeaponModel
        {
            Id = weapon.Id,
            Name = weapon.Name,
            Attack = weapon.Attack,
            Accuracy = weapon.Accuracy,
            Critical = weapon.Critical,
            Type = weapon.Type,
            Effect = weapon.Effect,
            Job = weapon.Job,
            SpritePath = weapon.SpritePath
        };
    }
}