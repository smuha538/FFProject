using Domain.Entities;
using Infrastructure.Entities;
using Infrastructure.Mappers;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

namespace Infrastructure.Repositories;

/// <inheritdoc cref="IGilsRepository"/>
public class GilsRepository(SupabaseClientService supabaseClientService, GilsEntityMapper mapper) : IGilsRepository
{
    /// <inheritdoc cref="IGilsRepository"/>
    public async Task<Gils> GetGilsByIdAsync(int userId)
    {
        var response = await supabaseClientService.Client
            .From<GilsEntity>()
            .Where(u => u.UserId == userId)
            .Single();

        if (response is null)
        {
            throw new Exception($"User {userId} not found");
        }
        
        return mapper.Map(response);
    }
}