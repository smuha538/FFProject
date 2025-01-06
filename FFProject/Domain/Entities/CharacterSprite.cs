using Domain.Enums;

namespace Domain.Entities;

/// <summary>
/// CharacterSprite entity
/// </summary>
public class CharacterSprite
{
    /// <summary>
    /// User ID
    /// </summary>
    public int UserId { get; set; }
    
    /// <summary>
    /// Character ID
    /// </summary>
    public int CharacterId { get; set; }
    
    /// <summary>
    /// Name of the sprite
    /// </summary>
    public required string SpriteName { get; set; }
    
    /// <summary>
    /// Type of the sprite
    /// </summary>
    public SpriteTypes SpriteType { get; set; }
    
    /// <summary>
    /// Path of the sprite
    /// </summary>
    public required string SpritePath { get; set; }
}