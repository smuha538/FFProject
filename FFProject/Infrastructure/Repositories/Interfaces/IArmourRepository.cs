using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces;

/// <summary>
/// Armour repository
/// </summary>
public interface IArmourRepository
{
    /// <summary>
    /// Gets all armour
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Armour>> GetArmoursAsync();
}