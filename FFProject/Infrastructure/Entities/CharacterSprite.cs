using Domain.Enums;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase characterSprite entity
/// </summary>
[Table("CharacterSprites")]
public class CharacterSprite: BaseModel
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
    public required string SpriteName { get; set; }
    
    /// <summary>
    /// Type of the sprite
    /// </summary>
    [PrimaryKey("sprite_type")]
    public SpriteTypes SpriteType { get; set; }
    
    /// <summary>
    /// Path of the sprite
    /// </summary>
    [Column("sprite_path")]
    public required string SpritePath { get; set; }
}