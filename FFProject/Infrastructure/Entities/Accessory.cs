using Domain.Enums;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase Accessory entity
/// </summary>
[Table("Accessories")]
public class Accessory: BaseModel
{
    /// <summary>
    /// Accessory ID
    /// </summary>
    [PrimaryKey("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the Accessory
    /// </summary>
    [Column("name")]
    public required string Name { get; set; }
    
    /// <summary>
    /// Defense stat of the Accessory
    /// </summary>
    [Column("def")]
    public int Defense { get; set; }
    
    /// <summary>
    /// Evasion stat of the Accessory
    /// </summary>
    [Column("eva")]
    public int Evasion { get; set; }
    
    /// <summary>
    /// Path of the sprite
    /// </summary>
    [Column("sprite_path")]
    public required string SpritePath { get; set; }
}