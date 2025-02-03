using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase track entity
/// </summary>
[Table("Tracks")]
public class TrackEntity: BaseModel
{
    /// <summary>
    /// Track ID
    /// </summary>
    [PrimaryKey("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Track title
    /// </summary>
    [Column("title")]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Artist of track
    /// </summary>
    [Column("artist")]
    public string Artist { get; set; } = string.Empty;

    /// <summary>
    /// File path of the track
    /// </summary>
    [Column("file_path")]
    public string FilePath { get; set; } = string.Empty;
}