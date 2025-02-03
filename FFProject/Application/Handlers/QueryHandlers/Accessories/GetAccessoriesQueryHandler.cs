using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.Accessories;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Accessories;

/// <summary>
/// Gets all accessories
/// </summary>
/// <param name="accessoryRepository"></param>
/// <param name="mapper"></param>
public class GetAccessoriesQueryHandler(IAccessoryRepository accessoryRepository, AccessoryModelMapper mapper): IRequestHandler<GetAccessoriesQuery, IEnumerable<AccessoryModel>>
{
    public async Task<IEnumerable<AccessoryModel>> Handle(GetAccessoriesQuery request, CancellationToken cancellationToken)
    {
        var accessories = await accessoryRepository.GetAllAccessoriesAsync();

        return accessories.Select(mapper.Map);
    }
}