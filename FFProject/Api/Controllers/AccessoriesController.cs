using Api.Resources;
using Application.Queries.Accessories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

/// <summary>
/// Accessories controller
/// </summary>
/// <param name="sender"></param>
[ApiController]
[Route("api/accessories")]
public class AccessoriesController(ISender sender): ControllerBase
{
    /// <summary>
    /// Gets all accessories
    /// </summary>
    /// <returns>accessories</returns>
    [HttpGet]
    public async Task<ActionResult<List<AccessoryResource>>> GetAccessories()
    {
        var query = new GetAccessoriesQuery();
        var accessoryModels = await sender.Send(query);

        var accessoryResources = accessoryModels.Select(accessory => new AccessoryResource
        {
            Id = accessory.Id,
            Name = accessory.Name,
            Evasion = accessory.Evasion,
            Defense = accessory.Defense,
            SpritePath = accessory.SpritePath
        }).ToList();

        return Ok(accessoryResources);
    }
}