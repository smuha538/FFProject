using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure userTrack entity to domain userTrack entity
/// </summary>
public class UserTrackEntityMapper
{
    public UserTrack Map(UserTrackEntity infrastructureUserTrack)
    {
        return new UserTrack
        {
            UserId = infrastructureUserTrack.UserId,
            MusicId = infrastructureUserTrack.MusicId
        };
    }
}