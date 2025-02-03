using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure userItem entity to domain userItem entity
/// </summary>
public class UserItemEntityMapper
{
    public UserItem Map(UserItemEntity infrastructureUserItem)
    {
        return new UserItem
        {
            UserId = infrastructureUserItem.UserId,
            ItemId = infrastructureUserItem.ItemId,
            Amount = infrastructureUserItem.Amount
        };
    }
}