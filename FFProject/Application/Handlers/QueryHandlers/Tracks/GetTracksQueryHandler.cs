using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.Tracks;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Tracks;

/// <summary>
/// Gets all tracks
/// </summary>
/// <param name="trackRepository"></param>
/// <param name="mapper"></param>
public class GetTracksQueryHandler(ITrackRepository trackRepository, TrackModelMapper mapper): IRequestHandler<GetTracksQuery, IEnumerable<TrackModel>>
{
    public async Task<IEnumerable<TrackModel>> Handle(GetTracksQuery request, CancellationToken cancellationToken)
    {
        var tracks = await trackRepository.GetTracksAsync();

        return tracks.Select(mapper.Map);
    }
}