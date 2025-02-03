using System.Text.Json.Serialization;

namespace Api.Resources;

/// <summary>
/// Track resource
/// </summary>
public class TrackResource
{
    /// <summary>
    /// Track ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Track title
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }
    
    /// <summary>
    /// Artist of track
    /// </summary>
    [JsonPropertyName("artist")]
    public string Artist { get; set; } = string.Empty;
    
    /// <summary>
    /// File path of the track
    /// </summary>
    [JsonPropertyName("file_path")]
    public required string FilePath { get; set; }
}