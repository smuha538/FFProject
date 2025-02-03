using Domain.Entities;
using Infrastructure.Entities;
using Infrastructure.Mappers;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

namespace Infrastructure.Repositories;

/// <inheritdoc cref="IAccessoryRepository"/>
public class AccessoryRepository(SupabaseClientService supabaseClientService, AccessoryEntityMapper mapper): IAccessoryRepository
{
    /// <inheritdoc cref="IAccessoryRepository"/>
    public async Task<IEnumerable<Accessory>> GetAllAccessoriesAsync()
    {
        var response = await supabaseClientService.Client
            .From<AccessoryEntity>()
            .Get();

        return response.Models.Select(mapper.Map);
    }
}