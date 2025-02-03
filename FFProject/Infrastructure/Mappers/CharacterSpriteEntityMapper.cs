using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure CharacterSprite entity to domain CharacterSprite entity
/// </summary>
public class CharacterSpriteEntityMapper
{
    public CharacterSprite Map(CharacterSpriteEntity infrastructureCharacterSprite)
    {
        return new CharacterSprite
        {
            UserId = infrastructureCharacterSprite.UserId,
            CharacterId = infrastructureCharacterSprite.CharacterId,
            SpriteName = infrastructureCharacterSprite.SpriteName,
            SpritePath = infrastructureCharacterSprite.SpritePath,
            SpriteType = infrastructureCharacterSprite.SpriteType
        };
    }
}