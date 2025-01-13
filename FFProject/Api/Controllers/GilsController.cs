using Api.Resources;
using Application.Queries.Gils;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

/// <summary>
/// Gils controller
/// </summary>
/// <param name="sender"></param>
[ApiController]
[Route("api/gils")]
public class GilsController(ISender sender): ControllerBase
{
    [HttpGet("{id}")]
    public async Task<ActionResult<GilsResource>> GetGilsById(int id)
    {
        var query = new GetGilsQuery(id);
        var gilsModel = await sender.Send(query);

        var gilsResource = new GilsResource
        {
            UserId = gilsModel.UserId,
            Amount = gilsModel.Amount
        };

        return Ok(gilsResource);
    }
}