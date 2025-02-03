using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure item entity to domain item entity
/// </summary>
public class ItemEntityMapper
{
    public Item Map(ItemEntity infrastructureItem)
    {
        return new Item
        {
            Id = infrastructureItem.Id,
            Name = infrastructureItem.Name,
            RestoreAmount = infrastructureItem.RestoreAmount,
            SpritePath = infrastructureItem.SpritePath
        };
    }
}