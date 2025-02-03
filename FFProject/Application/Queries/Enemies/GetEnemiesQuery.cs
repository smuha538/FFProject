using Application.Models;
using MediatR;

namespace Application.Queries.Enemies;

/// <summary>
/// Gets all enemies
/// </summary>
public record GetEnemiesQuery : IRequest<IEnumerable<EnemyModel>>;
