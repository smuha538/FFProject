using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.Armours;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Armours;

/// <summary>
/// Gets all armour
/// </summary>
/// <param name="armourRepository"></param>
/// <param name="mapper"></param>
public class GetArmoursQueryHandler(IArmourRepository armourRepository, ArmourModelMapper mapper): IRequestHandler<GetArmoursQuery, IEnumerable<ArmourModel>>
{
    public async Task<IEnumerable<ArmourModel>> Handle(GetArmoursQuery request, CancellationToken cancellationToken)
    {
        var armour = await armourRepository.GetArmoursAsync();

        return armour.Select(mapper.Map);
    }
}