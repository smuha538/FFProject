using Application.Models;
using MediatR;

namespace Application.Queries.Tracks;

/// <summary>
/// Gets all user tracks
/// </summary>
/// <param name="userId">User ID</param>
public class GetUserTracksQuery(int userId) : IRequest<IEnumerable<UserTrackModel>>
{
    public int UserId { get; set; } = userId;
}