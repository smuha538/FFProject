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
    public required string Title { get; set; }
    
    /// <summary>
    /// Artist of track
    /// </summary>
    [Column("artist")]
    public string Artist { get; set; }
    
    /// <summary>
    /// File path of the track
    /// </summary>
    [Column("file_path")]
    public required string FilePath { get; set; }
}