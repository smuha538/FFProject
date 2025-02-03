using Api.Resources;
using Application.Queries.Items;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

/// <summary>
/// Items controller
/// </summary>
[ApiController]
[Route("api/items")]
public class ItemsController(ISender sender): ControllerBase
{
    /// <summary>
    /// Gets all items
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<List<ItemResource>>> GetItems()
    {
        var query = new GetItemsQuery();
        var itemModels = await sender.Send(query);

        var itemResources = itemModels.Select(item => new ItemResource
        {
            Id = item.Id,
            Name = item.Name,
            RestoreAmount = item.RestoreAmount,
            SpritePath = item.SpritePath
        }).ToList();

        return Ok(itemResources);
    }
    
    /// <summary>
    /// Gets all items of a user
    /// </summary>
    /// <returns></returns>
    [HttpGet("user/{id}")]
    public async Task<ActionResult<List<UserItemResource>>> GetUserItems(int id)
    {
        var query = new GetUserItemsQuery(id);
        var itemModels = await sender.Send(query);

        var itemResources = itemModels.Select(item => new UserItemResource
        {
            UserId = item.UserId,
            ItemId = item.ItemId,
            Amount = item.Amount,
        }).ToList();

        return Ok(itemResources);
    }
}