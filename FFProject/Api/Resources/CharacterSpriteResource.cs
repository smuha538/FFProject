using System.Text.Json.Serialization;
using Domain.Enums;

namespace Api.Resources;

/// <summary>
/// CharacterSprite resource
/// </summary>
public class CharacterSpriteResource
{
    /// <summary>
    /// User ID
    /// </summary>
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
    
    /// <summary>
    /// Character ID
    /// </summary>
    [JsonPropertyName("character_id")]
    public int CharacterId { get; set; }
    
    /// <summary>
    /// Name of the sprite
    /// </summary>
    [JsonPropertyName("sprite_name")]
    public required string SpriteName { get; set; }
    
    /// <summary>
    /// Type of the sprite
    /// </summary>
    [JsonPropertyName("sprite_type")]
    public SpriteTypes SpriteType { get; set; }
    
    /// <summary>
    /// Path of the sprite
    /// </summary>
    [JsonPropertyName("sprite_path")]
    public required string SpritePath { get; set; }
}