using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure user entity to domain user entity
/// </summary>
public class UserEntityMapper
{
    public User Map(UserEntity infrastructureUser)
    {
        return new User
        {
            Id = infrastructureUser.Id,
            Username = infrastructureUser.Username,
            Email = infrastructureUser.Email,
            Password = infrastructureUser.Password,
        };
    }
}