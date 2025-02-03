using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure track entity to domain track entity
/// </summary>
public class TrackEntityMapper
{
    public Track Map(TrackEntity infrastructureTrack)
    {
        return new Track
        {
            Id = infrastructureTrack.Id,
            Artist = infrastructureTrack.Artist,
            Title = infrastructureTrack.Title,
            FilePath = infrastructureTrack.FilePath
        };
    }
}