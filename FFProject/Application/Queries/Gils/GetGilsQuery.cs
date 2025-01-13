using Application.Models;
using MediatR;

namespace Application.Queries.Gils;

public class GetGilsQuery(int userId): IRequest<GilsModel>
{
    public int UserId { get; set; } = userId;
}