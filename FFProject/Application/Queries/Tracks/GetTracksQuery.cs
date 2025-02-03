using Application.Models;
using MediatR;

namespace Application.Queries.Tracks;

/// <summary>
/// Gets all tracks
/// </summary>
public record GetTracksQuery : IRequest<IEnumerable<TrackModel>>;
