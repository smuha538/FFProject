using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces;

/// <summary>
/// Weapon Repository
/// </summary>
public interface IWeaponRepository
{
    /// <summary>
    /// Gets all weapons
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Weapon>> GetWeaponsAsync();
}