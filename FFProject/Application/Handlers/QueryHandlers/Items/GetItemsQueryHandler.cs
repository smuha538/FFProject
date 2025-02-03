using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.Items;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Items;

/// <summary>
/// Gets all items
/// </summary>
/// <param name="itemRepository"></param>
/// <param name="mapper"></param>
public class GetItemsQueryHandler(IItemRepository itemRepository, ItemModelMapper mapper): IRequestHandler<GetItemsQuery, IEnumerable<ItemModel>>
{
    public async Task<IEnumerable<ItemModel>> Handle(GetItemsQuery request, CancellationToken cancellationToken)
    {
        var items = await itemRepository.GetItemsAsync();
        
        return items.Select(mapper.Map);
    }
}