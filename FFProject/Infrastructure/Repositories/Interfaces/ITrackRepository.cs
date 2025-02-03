using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces;

/// <summary>
/// Track repository
/// </summary>
public interface ITrackRepository
{
    /// <summary>
    /// Get all tracks
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Track>> GetTracksAsync();
    
    /// <summary>
    /// Gets all tracks the user possesses
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<IEnumerable<UserTrack>> GetUserTracksAsync(int userId);
}