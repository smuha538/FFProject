using Api.Resources;
using Application.Queries.Shields;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

/// <summary>
/// Shields controller
/// </summary>
[ApiController]
[Route("api/shields")]
public class ShieldsController(ISender sender): ControllerBase
{
    /// <summary>
    /// Gets all shields
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<List<ShieldResource>>> GetShields()
    {
        var query = new GetShieldsQuery();
        var shieldModels = await sender.Send(query);

        var shieldResources = shieldModels.Select(shield => new ShieldResource
        {
            Id = shield.Id,
            Name = shield.Name,
            Job = shield.Job,
            Defense = shield.Defense,
            Evasion = shield.Evasion,
            SpritePath = shield.SpritePath
        }).ToList();

        return Ok(shieldResources);
    }
}