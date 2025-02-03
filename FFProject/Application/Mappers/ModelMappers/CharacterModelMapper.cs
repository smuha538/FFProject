using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain character entity to character model entity
/// </summary>
public class CharacterModelMapper
{
    public CharacterModel Map(Character character)
    {
        return new CharacterModel
        {
            UserId = character.UserId,
            Id = character.Id,
            Name = character.Name,
            Attack = character.Attack,
            Defense = character.Defense,
            Accuracy = character.Accuracy,
            Agile = character.Agile,
            Evasion = character.Evasion,
            Stamina = character.Stamina,
            MagicDefense = character.MagicDefense,
            ManaPoint = character.ManaPoint,
            HitPoint = character.HitPoint,
            Strength = character.Strength,
            Intelligence = character.Intelligence,
            CurrentExperience = character.CurrentExperience,
            Level = character.Level,
            Luck = character.Luck,
            NextLevel = character.NextLevel,
            Job = character.Job
        };
    }
}