using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces;

/// <summary>
/// Accessory repository
/// </summary>
public interface IAccessoryRepository
{
    /// <summary>
    /// Gets all accessories
    /// </summary>
    /// <returns>accessories</returns>
    Task<IEnumerable<Accessory>> GetAllAccessoriesAsync();
}