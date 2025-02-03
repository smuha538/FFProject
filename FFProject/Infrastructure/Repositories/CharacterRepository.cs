using Domain.Entities;
using Infrastructure.Entities;
using Infrastructure.Mappers;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

namespace Infrastructure.Repositories;

/// <inheritdoc cref="ICharacterRepository"/>
public class CharacterRepository(SupabaseClientService supabaseClientService, CharacterEntityMapper mapper, CharacterEquipmentEntityMapper equipmentMapper): ICharacterRepository
{
    /// <inheritdoc cref="ICharacterRepository"/>
    public async Task<IEnumerable<Character>> GetCharactersByUserIdAsync(int userId)
    {
        var response = await supabaseClientService.Client
            .From<CharacterEntity>()
            .Where(c => c.UserId == userId)
            .Get();
        
        if (response is null)
        {
            throw new Exception($"User {userId} not found");
        }
        
        return response.Models.Select(mapper.Map);
    }

    /// <inheritdoc cref="ICharacterRepository"/>
    public async Task<IEnumerable<CharacterEquipment>> GetCharacterEquipmentByUserIdAsync(int userId)
    {
        var response = await supabaseClientService.Client
            .From<CharacterEquipmentEntity>()
            .Where(c => c.UserId == userId)
            .Get();
        
        return response.Models.Select(equipmentMapper.Map);
    }
}