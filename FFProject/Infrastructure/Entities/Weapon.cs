using Domain.Enums;
using Supabase.Postgrest.Attributes;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase weapon entity
/// </summary>
[Table("Weapons")]
public class Weapon
{
    /// <summary>
    /// ID of the weapon
    /// </summary>
    [PrimaryKey("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the weapon
    /// </summary>
    [Column("name")]
    public required string Name { get; set; }
    
    /// <summary>
    /// Type of the weapon
    /// </summary>
    [Column("type")]
    public required string Type { get; set; }
    
    /// <summary>
    /// Attack damage of the weapon
    /// </summary>
    [Column("atk")]
    public int Attack { get; set; }
    
    /// <summary>
    /// Effect of the weapon
    /// </summary>
    [Column("effect")]
    public string Effect { get; set; }
    
    /// <summary>
    /// Jobs that can use the weapon
    /// </summary>
    [Column("job")]
    public Jobs Job { get; set; }
    
    /// <summary>
    /// Accuracy of the weapon
    /// </summary>
    [Column("acc")]
    public int Accuracy { get; set; }
    
    /// <summary>
    /// Critical damage of the weapon
    /// </summary>
    [Column("crit")]
    public int Critical { get; set; }
    
    /// <summary>
    /// Sprite path of the weapon
    /// </summary>
    [Column("sprite_path")]
    public required string SpritePath { get; set; }
}