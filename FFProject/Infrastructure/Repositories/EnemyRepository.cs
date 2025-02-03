using Domain.Entities;
using Infrastructure.Entities;
using Infrastructure.Mappers;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

namespace Infrastructure.Repositories;

/// <inheritdoc cref="IEnemyRepository"/>
public class EnemyRepository(SupabaseClientService supabaseClientService, EnemyEntityMapper mapper): IEnemyRepository
{
    /// <inheritdoc cref="IEnemyRepository"/>
    public async Task<IEnumerable<Enemy>> GetEnemiesAsync()
    {
        var response = await supabaseClientService.Client
            .From<EnemyEntity>()
            .Get();
        
        return response.Models.Select(mapper.Map);
    }
}