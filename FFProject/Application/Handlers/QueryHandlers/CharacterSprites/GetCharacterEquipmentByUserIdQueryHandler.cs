using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.CharacterSprites;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.CharacterSprites;

/// <summary>
/// Gets all character equipment of the user
/// </summary>
/// <param name="characterRepositoryRepository"></param>
/// <param name="mapper"></param>
public class GetCharacterEquipmentByUserIdQueryHandler(ICharacterRepository characterRepositoryRepository, CharacterEquipmentModelMapper mapper) : IRequestHandler<GetCharacterEquipmentByUserIdQuery, IEnumerable<CharacterEquipmentModel>>
{
    public async Task<IEnumerable<CharacterEquipmentModel>> Handle(GetCharacterEquipmentByUserIdQuery request, CancellationToken cancellationToken)
    {
        var characterSprites = await characterRepositoryRepository.GetCharacterEquipmentByUserIdAsync(request.UserId);

        return characterSprites.Select(mapper.Map);
    }
}