using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain user entity to user model entity
/// </summary>
public class UserModelMapper
{
    public UserModel Map(User user)
    {
        return new UserModel
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            Password = user.Password
        };
    }
}