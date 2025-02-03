using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain userItem entity to userItem model entity
/// </summary>
public class UserItemModelMapper
{
    public UserItemModel Map(UserItem userItem)
    {
        return new UserItemModel
        {
            UserId = userItem.UserId,
            ItemId = userItem.ItemId,
            Amount = userItem.Amount
        };
    }
}