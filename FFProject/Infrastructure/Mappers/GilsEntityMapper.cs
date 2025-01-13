using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure gils entity to domain gils entity
/// </summary>
public class GilsEntityMapper
{
    public Gils Map(GilsEntity infrastructureGils)
    {
        return new Gils
        {
            UserId = infrastructureGils.UserId,
            Amount = infrastructureGils.Amount,
        };
    }
}