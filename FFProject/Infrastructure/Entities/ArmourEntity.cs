using Domain.Enums;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase armour entity
/// </summary>
[Table("Armour")]
public class ArmourEntity: BaseModel
{
    /// <summary>
    /// Armour ID
    /// </summary>
    [PrimaryKey("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the armour
    /// </summary>
    [Column("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Jobs that can use the armour
    /// </summary>
    [Column("job")]
    public Jobs Job { get; set; }
    
    /// <summary>
    /// Defense stat of the armour
    /// </summary>
    [Column("def")]
    public int? Defense { get; set; }
    
    /// <summary>
    /// Evasion stat of the armour
    /// </summary>
    [Column("eva")]
    public int? Evasion { get; set; }
    
    /// <summary>
    /// Path of the sprite
    /// </summary>
    [Column("sprite_path")]
    public string SpritePath { get; set; } = string.Empty;
}