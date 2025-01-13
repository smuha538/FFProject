using Domain.Entities;
using Infrastructure.Entities;
using Infrastructure.Mappers;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

namespace Infrastructure.Repositories;

/// <inheritdoc cref="IUserRepository"/>
public class UserRepository(SupabaseClientService supabaseClientService, UserEntityMapper mapper) : IUserRepository
{
    /// <inheritdoc cref="IUserRepository"/>
    public async Task<User> GetUserByIdAsync(int userId)
    {
        var response = await supabaseClientService.Client
            .From<UserEntity>()
            .Where(u => u.Id == userId)
            .Single();
        
        if (response is null)
        {
            throw new Exception($"User {userId} not found");
        }
        
        return mapper.Map(response);
    }
}