using Domain.Enums;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase characterSprite entity
/// </summary>
[Table("CharacterSprites")]
public class CharacterSpriteEntity: BaseModel
{
    /// <summary>
    /// User ID
    /// </summary>
    [PrimaryKey("user_id")]
    public int UserId { get; set; }
    
    /// <summary>
    /// Character ID
    /// </summary>
    [PrimaryKey("character_id")]
    public int CharacterId { get; set; }
    
    /// <summary>
    /// Name of the sprite
    /// </summary>
    [Column("sprite_name")]
    public string SpriteName { get; set; } = string.Empty;
    
    /// <summary>
    /// Type of the sprite
    /// </summary>
    [PrimaryKey("sprite_type")]
    public SpriteTypes SpriteType { get; set; }
    
    /// <summary>
    /// Path of the sprite
    /// </summary>
    [Column("sprite_path")]
    public string SpritePath { get; set; } = string.Empty;
}