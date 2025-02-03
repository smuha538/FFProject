using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure character entity to domain character entity
/// </summary>
public class CharacterEntityMapper
{
    public Character Map(CharacterEntity infrastructureCharacter)
    {
        return new Character
        {
            UserId = infrastructureCharacter.UserId,
            Id = infrastructureCharacter.Id,
            Name = infrastructureCharacter.Name,
            Attack = infrastructureCharacter.Attack,
            Defense = infrastructureCharacter.Defense,
            Accuracy = infrastructureCharacter.Accuracy,
            Agile = infrastructureCharacter.Agile,
            Evasion = infrastructureCharacter.Evasion,
            Stamina = infrastructureCharacter.Stamina,
            MagicDefense = infrastructureCharacter.MagicDefense,
            ManaPoint = infrastructureCharacter.ManaPoint,
            HitPoint = infrastructureCharacter.HitPoint,
            Strength = infrastructureCharacter.Strength,
            Intelligence = infrastructureCharacter.Intelligence,
            CurrentExperience = infrastructureCharacter.CurrentExperience,
            Level = infrastructureCharacter.Level,
            Luck = infrastructureCharacter.Luck,
            NextLevel = infrastructureCharacter.NextLevel,
            Job = infrastructureCharacter.Job
        };
    }
}