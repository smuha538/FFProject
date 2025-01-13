using Api.Resources;
using Application.Queries.Users;
using Application.Queries.Weapons;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

/// <summary>
/// Weapons controller
/// </summary>
/// <param name="sender"></param>
[ApiController]
[Route("api/weapons")]
public class WeaponsController(ISender sender): ControllerBase
{
    /// <summary>
    /// Gets all weapons
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<List<WeaponResource>>> GetWeapons()
    {
        var query = new GetWeaponsQuery();
        var weaponModels = await sender.Send(query);

        var weaponResources = weaponModels.Select(weapon => new WeaponResource
        {
            Id = weapon.Id,
            Name = weapon.Name,
            Attack = weapon.Attack,
            Accuracy = weapon.Accuracy,
            Critical = weapon.Critical,
            Type = weapon.Type,
            Effect = weapon.Effect,
            Job = weapon.Job,
            SpritePath = weapon.SpritePath
        }).ToList();

        return Ok(weaponResources);
    }
}