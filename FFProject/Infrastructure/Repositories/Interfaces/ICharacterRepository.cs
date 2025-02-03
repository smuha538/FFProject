using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces;

/// <summary>
/// Character repository
/// </summary>
public interface ICharacterRepository
{
    /// <summary>
    /// Gets all the characters of the user
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Character>> GetCharactersByUserIdAsync(int userId);
    
    /// <summary>
    /// Gets all character equipment of the user
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<CharacterEquipment>> GetCharacterEquipmentByUserIdAsync(int userId);
}