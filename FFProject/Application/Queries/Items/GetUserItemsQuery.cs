using Application.Models;
using MediatR;

namespace Application.Queries.Items;

/// <summary>
/// Gets user items
/// </summary>
/// <param name="userId">User ID</param>
public class GetUserItemsQuery(int userId) :IRequest<IEnumerable<UserItemModel>>
{
    public int UserId { get; set; } = userId;
}