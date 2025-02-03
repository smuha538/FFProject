using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain userTrack entity to userTrack model entity
/// </summary>
public class UserTrackModelMapper
{
    public UserTrackModel Map(UserTrack userTrack)
    {
        return new UserTrackModel
        {
            UserId = userTrack.UserId,
            MusicId = userTrack.MusicId
        };
    }
}