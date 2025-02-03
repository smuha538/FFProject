using Domain.Entities;
using Infrastructure.Entities;
using Infrastructure.Mappers;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;
using Supabase.Postgrest;

namespace Infrastructure.Repositories;

/// <inheritdoc cref="IItemRepository"/>
public class ItemRepository(SupabaseClientService supabaseClientService, ItemEntityMapper itemMapper, UserItemEntityMapper userItemMapper): IItemRepository
{

    /// <inheritdoc cref="IItemRepository"/>
    public async Task<IEnumerable<Item>> GetItemsAsync()
    {
        var response = await supabaseClientService.Client
            .From<ItemEntity>()
            .Get();
        
        return response.Models.Select(itemMapper.Map);
    }

    /// <inheritdoc cref="IItemRepository"/>
    public async Task<IEnumerable<UserItem>> GetUserItemsByUserIdAsync(int userId)
    {
        var response = await supabaseClientService.Client
            .From<UserItemEntity>()
            .Where(u => u.UserId == userId)
            .Get();
        
        return response.Models.Select(userItemMapper.Map);
    }
}