using Application.Models;
using MediatR;

namespace Application.Queries.Users;

/// <summary>
/// Gets user by ID
/// </summary>
/// <param name="userId">User ID</param>
public class GetUserQuery(int userId) : IRequest<UserModel>
{
    public int UserId { get; set; } = userId;
}