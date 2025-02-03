using Application.Models;
using MediatR;

namespace Application.Queries.Items;

/// <summary>
/// Gets all items
/// </summary>
public record GetItemsQuery : IRequest<IEnumerable<ItemModel>>;