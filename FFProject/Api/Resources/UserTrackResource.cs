using System.Text.Json.Serialization;

namespace Api.Resources;

/// <summary>
/// UserTrack resource
/// </summary>
public class UserTrackResource
{
    /// <summary>
    /// User ID
    /// </summary>
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
    
    /// <summary>
    /// Music ID
    /// </summary>
   [JsonPropertyName("music_id")]
    public int MusicId { get; set; }
}