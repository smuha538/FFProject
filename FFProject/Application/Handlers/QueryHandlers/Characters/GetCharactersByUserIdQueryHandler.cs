using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.Characters;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Characters;

/// <summary>
/// Gets all characters of the user
/// </summary>
/// <param name="characterRepository"></param>
/// <param name="mapper"></param>
public class GetCharactersByUserIdQueryHandler(ICharacterRepository characterRepository, CharacterModelMapper mapper) : IRequestHandler<GetCharactersQuery, IEnumerable<CharacterModel>>
{
    public async Task<IEnumerable<CharacterModel>> Handle(GetCharactersQuery request, CancellationToken cancellationToken)
    {
        var characters = await characterRepository.GetCharactersByUserIdAsync(request.UserId);

        return characters.Select(mapper.Map);
    }
}