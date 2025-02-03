using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces;

/// <summary>
/// Enemy repository
/// </summary>
public interface IEnemyRepository
{
    /// <summary>
    /// Gets all the enemies
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Enemy>> GetEnemiesAsync();
}