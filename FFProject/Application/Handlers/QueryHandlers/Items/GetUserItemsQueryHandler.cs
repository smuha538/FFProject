using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.Items;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Items;

/// <summary>
/// Gets user items
/// </summary>
/// <param name="itemRepository"></param>
public class GetUserItemsQueryHandler(IItemRepository itemRepository, UserItemModelMapper mapper) : IRequestHandler<GetUserItemsQuery, IEnumerable<UserItemModel>>
{
    public async Task<IEnumerable<UserItemModel>> Handle(GetUserItemsQuery request, CancellationToken cancellationToken)
    {
        var userItems = await itemRepository.GetUserItemsByUserIdAsync(request.UserId);
        
        return userItems.Select(mapper.Map);
    }
}