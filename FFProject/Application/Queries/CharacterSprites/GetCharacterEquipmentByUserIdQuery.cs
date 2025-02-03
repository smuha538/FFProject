using Application.Models;
using MediatR;

namespace Application.Queries.CharacterSprites;

/// <summary>
/// Get character equipment by user ID
/// </summary>
/// <param name="userId">User ID</param>
public class GetCharacterEquipmentByUserIdQuery(int userId): IRequest<IEnumerable<CharacterEquipmentModel>>
{
    public int UserId { get; set; } = userId;
}