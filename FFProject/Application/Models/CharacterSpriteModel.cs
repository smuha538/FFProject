using Domain.Enums;

namespace Application.Models;

/// <summary>
/// CharacterSprite model
/// </summary>
public class CharacterSpriteModel
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
    public string SpriteName { get; set; } = string.Empty;
    
    /// <summary>
    /// Type of the sprite
    /// </summary>
    public SpriteTypes SpriteType { get; set; }
    
    /// <summary>
    /// Path of the sprite
    /// </summary>
    public string SpritePath { get; set; } = string.Empty;
}