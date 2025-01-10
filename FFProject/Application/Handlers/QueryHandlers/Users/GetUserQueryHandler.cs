using Application.Models;
using Application.Queries.Users;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Users;

public class GetUserQueryHandler(IUserRepository userRepository) : IRequestHandler<GetUserQuery, UserModel>
{
    public async Task<UserModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var user = await userRepository.GetUserByIdAsync(request.UserId);

        return new UserModel
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email
        };
    }
}