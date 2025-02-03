using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces;

/// <summary>
/// CharacterSprite repository
/// </summary>
public interface ICharacterSpriteRepository
{
    /// <summary>
    /// Gets all character sprites of a user ID
    /// </summary>
    /// <param name="userId">user Ids</param>
    /// <returns></returns>
    Task<IEnumerable<CharacterSprite>> GetAllCharacterSpritesByUserIdAsync(int userId);
}