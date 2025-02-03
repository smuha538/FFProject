using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.Weapons;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Weapons;

/// <summary>
/// Gets all weapons
/// </summary>
/// <param name="weaponRepository"></param>
/// <param name="mapper"></param>
public class GetWeaponsQueryHandler(IWeaponRepository weaponRepository, WeaponModelMapper mapper): IRequestHandler<GetWeaponsQuery, IEnumerable<WeaponModel>>
{
    public async Task<IEnumerable<WeaponModel>> Handle(GetWeaponsQuery request, CancellationToken cancellationToken)
    {
        var weapons = await weaponRepository.GetWeaponsAsync();

        return weapons.Select(mapper.Map);
    }
}