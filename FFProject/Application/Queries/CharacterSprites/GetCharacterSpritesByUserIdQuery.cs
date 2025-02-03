using Application.Models;
using MediatR;

namespace Application.Queries.CharacterSprites;

/// <summary>
/// Gets all character sprites of a user
/// </summary>
/// <param name="userId">User ID</param>
public class GetCharacterSpritesByUserIdQuery(int userId): IRequest<IEnumerable<CharacterSpriteModel>>
{
    public int UserId { get; set; } = userId;
}