using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase userMusic entity
/// </summary>
[Table("UserTracks")]
public class UserTrackEntity: BaseModel
{
    /// <summary>
    /// User ID
    /// </summary>
    [PrimaryKey("user_id")]
    public int UserId { get; set; }
    
    /// <summary>
    /// Music ID
    /// </summary>
    [PrimaryKey("music_id")]
    public int MusicId { get; set; }
}