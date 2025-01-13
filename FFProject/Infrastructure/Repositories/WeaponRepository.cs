using Domain.Entities;
using Infrastructure.Entities;
using Infrastructure.Mappers;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

namespace Infrastructure.Repositories;

/// <inheritdoc cref="IWeaponRepository"/>
public class WeaponRepository (SupabaseClientService supabaseClientService, WeaponEntityMapper mapper) : IWeaponRepository
{
    /// <inheritdoc cref="IWeaponRepository"/>
    public async Task<List<Weapon>> GetWeaponsAsync()
    {
        var response = await supabaseClientService.Client
            .From<WeaponEntity>()
            .Get();
        
        return response.Models.Select(mapper.Map).ToList();
    }
}