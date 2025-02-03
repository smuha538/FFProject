using Application.Models;
using MediatR;

namespace Application.Queries.Characters;

/// <summary>
/// Gets all characters of a user
/// </summary>
/// <param name="userId">User ID</param>
public class GetCharactersQuery(int userId) : IRequest<IEnumerable<CharacterModel>>
{
    public int UserId { get; set; } = userId;
}