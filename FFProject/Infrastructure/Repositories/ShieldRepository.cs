using Domain.Entities;
using Infrastructure.Entities;
using Infrastructure.Mappers;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

namespace Infrastructure.Repositories;

/// <inheritdoc cref="IShieldRepository"/>
public class ShieldRepository(SupabaseClientService supabaseClientService, ShieldEntityMapper mapper): IShieldRepository
{
    /// <inheritdoc cref="IShieldRepository"/>
    public async Task<List<Shield>> GetShieldsAsync()
    {
        var response = await supabaseClientService.Client
            .From<ShieldEntity>()
            .Get();
        
        return response.Models.Select(mapper.Map).ToList();
    }
}