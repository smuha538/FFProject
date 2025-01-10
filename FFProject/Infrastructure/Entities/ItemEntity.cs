using Domain.Enums;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase item entity
/// </summary>
[Table("Items")]
public class ItemEntity: BaseModel
{
    /// <summary>
    /// Item ID
    /// </summary>
    [PrimaryKey("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the item
    /// </summary>
    [Column("name")]
    public required string Name { get; set; }
    
    /// <summary>
    /// Type of item
    /// </summary>
    [Column("type")]
    public Types Type { get; set; }
    
    /// <summary>
    /// Price of the item
    /// </summary>
    [Column("price")]
    public int Price { get; set; }
    
    /// <summary>
    /// Amount the item restores
    /// </summary>
    [Column("restore_amount")]
    public int RestoreAmount { get; set; }
    
    /// <summary>
    /// Sprite path of the item
    /// </summary>
    [Column("sprite_path")]
    public required string SpritePath { get; set; }
}