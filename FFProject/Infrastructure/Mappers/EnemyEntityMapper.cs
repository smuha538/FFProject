using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure enemy entity to domain enemy entity
/// </summary>
public class EnemyEntityMapper
{
    public Enemy Map(EnemyEntity infrastructureEnemy)
    {
        return new Enemy
        {
            Id = infrastructureEnemy.Id,
            Name = infrastructureEnemy.Name,
            Attack = infrastructureEnemy.Attack,
            Defense = infrastructureEnemy.Defense,
            MagicDefense = infrastructureEnemy.MagicDefense,
            Hit = infrastructureEnemy.Hit,
            Hp = infrastructureEnemy.Hp,
            Experience = infrastructureEnemy.Experience,
            SpritePath = infrastructureEnemy.SpritePath,
        };
    }
}