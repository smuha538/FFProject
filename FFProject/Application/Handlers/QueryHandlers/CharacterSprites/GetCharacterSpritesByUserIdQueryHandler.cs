using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.CharacterSprites;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.CharacterSprites;

/// <summary>
/// Gets all character sprites of a user
/// </summary>
/// <param name="characterSpriteRepositoryRepository"></param>
/// <param name="mapper"></param>
public class GetCharacterSpritesByUserIdQueryHandler(ICharacterSpriteRepository characterSpriteRepositoryRepository, CharacterSpriteModelMapper mapper) : IRequestHandler<GetCharacterSpritesByUserIdQuery, IEnumerable<CharacterSpriteModel>>
{
    public async Task<IEnumerable<CharacterSpriteModel>> Handle(GetCharacterSpritesByUserIdQuery request, CancellationToken cancellationToken)
    {
        var characterSprites = await characterSpriteRepositoryRepository.GetAllCharacterSpritesByUserIdAsync(request.UserId);

        return characterSprites.Select(mapper.Map);
    }
}