using Api.Resources;
using Application.Queries.Armours;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

/// <summary>
/// Armours controller
/// </summary>
/// <param name="sender"></param>
[ApiController]
[Route("api/armours")]
public class ArmoursController(ISender sender): ControllerBase
{
    /// <summary>
    /// Gets all armour
    /// </summary>
    /// <returns>armours</returns>
    [HttpGet]
    public async Task<ActionResult<List<ArmourResource>>> GetArmours()
    {
        var query = new GetArmoursQuery();
        var armourModels = await sender.Send(query);

        var armourResources = armourModels.Select(armour => new ArmourResource
        {
            Id = armour.Id,
            Name = armour.Name,
            Evasion = armour.Evasion,
            Defense = armour.Defense,
            Job = armour.Job,
            SpritePath = armour.SpritePath
        }).ToList();

        return Ok(armourResources);
    }
}