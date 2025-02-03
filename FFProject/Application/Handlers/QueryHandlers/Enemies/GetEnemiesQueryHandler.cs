using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.Enemies;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Enemies;

/// <summary>
/// Get all enemies
/// </summary>
/// <param name="enemyRepository"></param>
/// <param name="mapper"></param>
public class GetEnemiesQueryHandler(IEnemyRepository enemyRepository, EnemyModelMapper mapper): IRequestHandler<GetEnemiesQuery, IEnumerable<EnemyModel>>
{
    public async Task<IEnumerable<EnemyModel>> Handle(GetEnemiesQuery request, CancellationToken cancellationToken)
    {
        var enemies = await enemyRepository.GetEnemiesAsync();

        return enemies.Select(mapper.Map);
    }
}