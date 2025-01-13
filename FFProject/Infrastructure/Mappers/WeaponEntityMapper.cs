using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure weapon entity to domain weapon entity
/// </summary>
public class WeaponEntityMapper
{
    public Weapon Map(WeaponEntity infrastructureWeapon)
    {
        return new Weapon
        {
            Id = infrastructureWeapon.Id,
            Name = infrastructureWeapon.Name,
            Attack = infrastructureWeapon.Attack,
            Accuracy = infrastructureWeapon.Accuracy,
            Critical = infrastructureWeapon.Critical,
            Type = infrastructureWeapon.Type,
            Effect = infrastructureWeapon.Effect,
            Job = infrastructureWeapon.Job,
            SpritePath = infrastructureWeapon.SpritePath
        };
    }
}