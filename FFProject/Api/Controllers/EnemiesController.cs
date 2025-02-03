using Api.Resources;
using Application.Queries.Enemies;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

/// <summary>
/// Enemies controller
/// </summary>
/// <param name="sender"></param>
[ApiController]
[Route("api/enemies")]
public class EnemiesController(ISender sender): ControllerBase
{
    /// <summary>
    /// Gets all enemies
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<List<EnemyResource>>> GetEnemies()
    {
        var query = new GetEnemiesQuery();
        var enemyModels = await sender.Send(query);

        var enemyResources = enemyModels.Select(enemy => new EnemyResource
        {
            Id = enemy.Id,
            Name = enemy.Name,
            Attack = enemy.Attack,
            Defense = enemy.Defense,
            MagicDefense = enemy.MagicDefense,
            Hit = enemy.Hit,
            Hp = enemy.Hp,
            Experience = enemy.Experience,
            SpritePath = enemy.SpritePath,
        }).ToList();

        return Ok(enemyResources);
    }
}