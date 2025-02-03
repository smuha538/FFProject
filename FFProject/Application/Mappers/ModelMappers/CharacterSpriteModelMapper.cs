using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain characterSprite entity to characterSprite model entity
/// </summary>
public class CharacterSpriteModelMapper
{
    public CharacterSpriteModel Map(CharacterSprite characterSprite)
    {
        return new CharacterSpriteModel
        {
            CharacterId = characterSprite.CharacterId,
            UserId = characterSprite.UserId,
            SpriteName = characterSprite.SpriteName,
            SpriteType = characterSprite.SpriteType,
            SpritePath = characterSprite.SpritePath
        };
    }
}