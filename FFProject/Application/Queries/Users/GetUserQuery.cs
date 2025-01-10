using Application.Models;
using MediatR;

namespace Application.Queries.Users;

public class GetUserQuery(int userId) : IRequest<UserModel>
{
    public int UserId { get; set; } = userId;
}