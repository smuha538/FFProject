using Domain.Entities;
using Infrastructure.Entities;
using Infrastructure.Mappers;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

namespace Infrastructure.Repositories;

/// <inheritdoc cref="ICharacterSpriteRepository"/>
public class CharacterSpriteRepository(SupabaseClientService supabaseClientService, CharacterSpriteEntityMapper mapper): ICharacterSpriteRepository
{
    /// <inheritdoc cref="ICharacterSpriteRepository"/>
    public async Task<IEnumerable<CharacterSprite>> GetAllCharacterSpritesByUserIdAsync(int userId)
    {
        var response = await supabaseClientService.Client
            .From<CharacterSpriteEntity>()
            .Where(c => c.UserId == userId)
            .Get();

        return response.Models.Select(mapper.Map);
    }
}