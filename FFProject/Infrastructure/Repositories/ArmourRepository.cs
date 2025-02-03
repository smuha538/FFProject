using Domain.Entities;
using Infrastructure.Entities;
using Infrastructure.Mappers;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

namespace Infrastructure.Repositories;

/// <inheritdoc cref="IArmourRepository"/>
public class ArmourRepository(SupabaseClientService supabaseClientService, ArmourEntityMapper mapper): IArmourRepository
{
    /// <inheritdoc cref="IArmourRepository"/>
    public async Task<IEnumerable<Armour>> GetArmoursAsync()
    {
        var response = await supabaseClientService.Client
            .From<ArmourEntity>()
            .Get();
        
        return response.Models.Select(mapper.Map);
    }
}