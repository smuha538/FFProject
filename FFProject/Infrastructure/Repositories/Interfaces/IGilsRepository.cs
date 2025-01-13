using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces;

/// <summary>
/// Gils repository
/// </summary>
public interface IGilsRepository
{
    /// <summary>
    /// Gets a user's gils
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<Gils> GetGilsByIdAsync(int userId);
}