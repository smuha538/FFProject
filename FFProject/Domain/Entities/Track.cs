namespace Domain.Entities;

/// <summary>
/// Track entity
/// </summary>
public class Track
{
    /// <summary>
    /// Track ID
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Track title
    /// </summary>
    public required string Title { get; set; }
    
    /// <summary>
    /// Artist of track
    /// </summary>
    public string Artist { get; set; }
    
    /// <summary>
    /// File path of the track
    /// </summary>
    public required string FilePath { get; set; }
}