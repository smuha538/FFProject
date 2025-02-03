using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces;

/// <summary>
/// Item repository
/// </summary>
public interface IItemRepository
{
    /// <summary>
    /// Gets all items
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Item>> GetItemsAsync();
    
    /// <summary>
    /// Gets all items the user possesses
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<IEnumerable<UserItem>> GetUserItemsByUserIdAsync(int userId);
}