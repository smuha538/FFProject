using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces;

/// <summary>
/// Shield repository
/// </summary>
public interface IShieldRepository
{
    /// <summary>
    /// Gets all shields
    /// </summary>
    /// <returns></returns>
    Task<List<Shield>> GetShieldsAsync();
}