using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.Tracks;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Tracks;

/// <summary>
/// Gets all user tracks
/// </summary>
/// <param name="userTrackRepository"></param>
/// <param name="mapper"></param>
public class GetUserTracksQueryHandler(ITrackRepository userTrackRepository, UserTrackModelMapper mapper) : IRequestHandler<GetUserTracksQuery, IEnumerable<UserTrackModel>>
{
    public async Task<IEnumerable<UserTrackModel>> Handle(GetUserTracksQuery request, CancellationToken cancellationToken)
    {
        var userTracks = await userTrackRepository.GetUserTracksAsync(request.UserId);

        return userTracks.Select(mapper.Map);
    }
}