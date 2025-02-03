using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain item entity to item model entity
/// </summary>
public class ItemModelMapper
{
    public ItemModel Map(Item item)
    {
        return new ItemModel
        {
            Id = item.Id,
            Name = item.Name,
            RestoreAmount = item.RestoreAmount,
            SpritePath = item.SpritePath
        };
    }
}