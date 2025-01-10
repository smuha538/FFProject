using Api.Resources;
using Application.Queries.Users;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController(ISender sender) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<ActionResult<UserResource>> GetUserById(int id)
    {
        var query = new GetUserQuery(id);
        var userModel = await sender.Send(query);

        var userResource = new UserResource
        {
            Id = userModel.Id,
            Username = userModel.Username,
            Email = userModel.Email
        };

        return Ok(userResource);
    }
}