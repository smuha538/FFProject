using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.Shields;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Shields;

/// <summary>
/// Gets all shields
/// </summary>
/// <param name="shieldRepository"></param>
/// <param name="mapper"></param>
public class GetShieldsQueryHandler(IShieldRepository shieldRepository, ShieldModelMapper mapper): IRequestHandler<GetShieldsQuery, List<ShieldModel>>
{
    public async Task<List<ShieldModel>> Handle(GetShieldsQuery request, CancellationToken cancellationToken)
    {
        var shields = await shieldRepository.GetShieldsAsync();

        return shields.Select(mapper.Map).ToList();
    }
}