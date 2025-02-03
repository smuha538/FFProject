using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase enemy entity
/// </summary>
[Table("Enemies")]
public class EnemyEntity: BaseModel
{
    /// <summary>
    /// Enemy ID
    /// </summary>
    [PrimaryKey("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the enemy
    /// </summary>
    [Column("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Hp of the enemy
    /// </summary>
    [Column("hp")]
    public int Hp { get; set; }
    
    /// <summary>
    /// Experience awarded for beating the enemy
    /// </summary>
    [Column("exp")]
    public int Experience { get; set; }
    
    /// <summary>
    /// Attack stat of the enemy
    /// </summary>
    [Column("atk")]
    public int Attack { get; set; }
    
    /// <summary>
    /// Defense stat of the enemy
    /// </summary>
    [Column("def")]
    public int Defense { get; set; }
    
    /// <summary>
    /// Magic defense stat of the enemy
    /// </summary>
    [Column("mdef")]
    public int MagicDefense { get; set; }
    
    /// <summary>
    /// Hit rate stat of the enemy
    /// </summary>
    [Column("hit")]
    public int Hit { get; set; }
    
    /// <summary>
    /// Sprite path of the item
    /// </summary>
    [Column("sprite_path")]
    public string SpritePath { get; set; } = string.Empty;
}