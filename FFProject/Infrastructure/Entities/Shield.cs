using Domain.Enums;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase shield entity
/// </summary>
[Table("Shields")]
public class Shield: BaseModel
{
    /// <summary>
    /// Shield ID
    /// </summary>
    [PrimaryKey("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the shield
    /// </summary>
    [Column("name")]
    public required string Name { get; set; }
    
    /// <summary>
    /// Jobs that can use the shield
    /// </summary>
    [Column("job")]
    public Jobs Job { get; set; }
    
    /// <summary>
    /// Defense stat of the shield
    /// </summary>
    [Column("def")]
    public int Defense { get; set; }
    
    /// <summary>
    /// Evasion stat of the shield
    /// </summary>
    [Column("eva")]
    public int Evasion { get; set; }
    
    /// <summary>
    /// Sprite path of the shield
    /// </summary>
    [Column("sprite_path")]
    public required string SpritePath { get; set; }
}