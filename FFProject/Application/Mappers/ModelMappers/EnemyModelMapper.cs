using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain enemy entity to enemy model entity
/// </summary>
public class EnemyModelMapper
{
    public EnemyModel Map(Enemy enemy)
    {
        return new EnemyModel
        {
            Id = enemy.Id,
            Name = enemy.Name,
            Attack = enemy.Attack,
            Defense = enemy.Defense,
            MagicDefense = enemy.MagicDefense,
            Hit = enemy.Hit,
            Hp = enemy.Hp,
            Experience = enemy.Experience,
            SpritePath = enemy.SpritePath,
        };
    }
}