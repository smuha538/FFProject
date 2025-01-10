using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces;

/// <summary>
/// User Repository
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Gets user by ID
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<User> GetUserByIdAsync(int userId);
}