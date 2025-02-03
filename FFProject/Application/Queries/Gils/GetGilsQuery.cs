using Application.Models;
using MediatR;

namespace Application.Queries.Gils;

/// <summary>
/// Gets all the user's gills
/// </summary>
/// <param name="userId">User ID</param>
public class GetGilsQuery(int userId): IRequest<GilsModel>
{
    public int UserId { get; set; } = userId;
}