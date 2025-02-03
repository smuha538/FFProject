using Api.Resources;
using Application.Queries.CharacterSprites;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/character-sprites")]
public class CharacterSpritesController(ISender sender): ControllerBase
{
    /// <summary>
    /// Gets character sprites by user ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<List<CharacterSpriteResource>>> GetCharacterSpritesByUserId(int id)
    {
        var query = new GetCharacterSpritesByUserIdQuery(id);
        var characterSpriteModels = await sender.Send(query);

        var characterSpriteResources = characterSpriteModels.Select(characterSprite => new CharacterSpriteResource
        {
            UserId = characterSprite.UserId,
            CharacterId = characterSprite.CharacterId,
            SpritePath = characterSprite.SpritePath,
            SpriteName = characterSprite.SpriteName,
            SpriteType = characterSprite.SpriteType
        }).ToList();

        return Ok(characterSpriteResources);
    }
}