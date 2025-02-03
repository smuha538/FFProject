using Api.Resources;
using Application.Queries.Tracks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

/// <summary>
/// Tracks controller
/// </summary>
/// <param name="sender"></param>
[ApiController]
[Route("api/tracks")]
public class TracksController(ISender sender): ControllerBase
{
    /// <summary>
    /// Gets all tracks
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<List<TrackResource>>> GetTracks()
    {
        var query = new GetTracksQuery();
        var trackModels = await sender.Send(query);

        var trackResources = trackModels.Select(track => new TrackResource
        {
            Id = track.Id,
            Artist = track.Artist,
            Title = track.Title,
            FilePath = track.FilePath
        }).ToList();

        return Ok(trackResources);
    }

    /// <summary>
    /// Gets all user tracks
    /// </summary>
    /// <param name="id">User ID</param>
    /// <returns></returns>
    [HttpGet("user/{id}")]
    public async Task<ActionResult<List<UserTrackResource>>> GetUserTracks(int id)
    {
        var query = new GetUserTracksQuery(id);
        var userTrackModels = await sender.Send(query);
        
        var userTrackResources = userTrackModels.Select(userTrack => new UserTrackResource
        {
            UserId = userTrack.UserId,
            MusicId = userTrack.MusicId
        }).ToList();
        
        return Ok(userTrackResources);
    }
}