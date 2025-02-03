using Domain.Entities;
using Infrastructure.Entities;
using Infrastructure.Mappers;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

namespace Infrastructure.Repositories;

/// <inheritdoc cref="ITrackRepository"/>
public class TrackRepository(SupabaseClientService supabaseClientService, TrackEntityMapper trackMapper, UserTrackEntityMapper userTrackMapper): ITrackRepository
{
    /// <inheritdoc cref="ITrackRepository"/>
    public async Task<IEnumerable<Track>> GetTracksAsync()
    {
        var response = await supabaseClientService.Client
            .From<TrackEntity>()
            .Get();
        
        return response.Models.Select(trackMapper.Map);
    }

    /// <inheritdoc cref="ITrackRepository"/>
    public async Task<IEnumerable<UserTrack>> GetUserTracksAsync(int userId)
    {
        var response = await supabaseClientService.Client
            .From<UserTrackEntity>()
            .Where(u => u.UserId == userId)
            .Get();
        
        return response.Models.Select(userTrackMapper.Map);
    }
}