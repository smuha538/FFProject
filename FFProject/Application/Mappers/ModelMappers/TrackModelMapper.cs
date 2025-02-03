using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain track entity to track model entity
/// </summary>
public class TrackModelMapper
{
    public TrackModel Map(Track track)
    {
        return new TrackModel
        {
            Id = track.Id,
            Title = track.Title,
            Artist = track.Artist,
            FilePath = track.FilePath
        };
    }
}