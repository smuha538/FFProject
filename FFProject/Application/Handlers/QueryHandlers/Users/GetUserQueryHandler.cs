using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.Users;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Users;

/// <summary>
/// Gets user by ID
/// </summary>
/// <param name="userRepository"></param>
/// <param name="mapper"></param>
public class GetUserQueryHandler(IUserRepository userRepository, UserModelMapper mapper) : IRequestHandler<GetUserQuery, UserModel>
{
    public async Task<UserModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var user = await userRepository.GetUserByIdAsync(request.UserId);

        return mapper.Map(user);
    }
}