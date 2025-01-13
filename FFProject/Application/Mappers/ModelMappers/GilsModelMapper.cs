using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain gils entity to gils model entity
/// </summary>
public class GilsModelMapper
{
    public GilsModel Map(Gils gils)
    {
        return new GilsModel
        {
            UserId = gils.UserId,
            Amount = gils.Amount
        };
    }
}