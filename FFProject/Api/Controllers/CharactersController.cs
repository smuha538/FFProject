using Api.Resources;
using Application.Queries.Characters;
using Application.Queries.CharacterSprites;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

/// <summary>
/// Characters controller
/// </summary>
[ApiController]
[Route("api/characters")]
public class CharactersController(ISender sender): ControllerBase
{
    /// <summary>
    /// Gets characters by user ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<List<CharacterResource>>> GetCharactersByUserId(int id)
    {
        var query = new GetCharactersQuery(id);
        var characterModels = await sender.Send(query);

        var characterResources = characterModels.Select(character => new CharacterResource
        {
            UserId = character.UserId,
            Id = character.Id,
            Name = character.Name,
            Attack = character.Attack,
            Defense = character.Defense,
            Accuracy = character.Accuracy,
            Agile = character.Agile,
            Evasion = character.Evasion,
            Stamina = character.Stamina,
            MagicDefense = character.MagicDefense,
            ManaPoint = character.ManaPoint,
            HitPoint = character.HitPoint,
            Strength = character.Strength,
            Intelligence = character.Intelligence,
            CurrentExperience = character.CurrentExperience,
            Level = character.Level,
            Luck = character.Luck,
            NextLevel = character.NextLevel,
            Job = character.Job
        }).ToList();

        return Ok(characterResources);
    }
    
    /// <summary>
    /// Gets characters by user ID
    /// </summary>
    /// <param name="id">User ID</param>
    /// <returns></returns>
    [HttpGet("equipment/{id}")]
    public async Task<ActionResult<List<CharacterEquipmentResource>>> GetCharacterEquipmentByUserId(int id)
    {
        var query = new GetCharacterEquipmentByUserIdQuery(id);
        var characterEquipmentModels = await sender.Send(query);

        var characterEquipmentResources = characterEquipmentModels.Select(characterEquipment => new CharacterEquipmentResource
        {
            UserId = characterEquipment.UserId,
            ArmourId = characterEquipment.ArmourId,
            AccessoryId = characterEquipment.AccessoryId,
            CharacterId = characterEquipment.CharacterId,
            WeaponId = characterEquipment.WeaponId,
            ShieldId = characterEquipment.ShieldId
        }).ToList();

        return Ok(characterEquipmentResources);
    }
}