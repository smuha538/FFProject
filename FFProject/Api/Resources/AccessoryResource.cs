using System.Text.Json.Serialization;

namespace Api.Resources;

/// <summary>
/// Accessory resource
/// </summary>
public class AccessoryResource
{
    /// <summary>
    /// Accessory ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the Accessory
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    /// <summary>
    /// Defense stat of the Accessory
    /// </summary>
    [JsonPropertyName("defense")]
    public int? Defense { get; set; }
    
    /// <summary>
    /// Evasion stat of the Accessory
    /// </summary>
    [JsonPropertyName("evasion")]
    public int? Evasion { get; set; }
    
    /// <summary>
    /// Path of the sprite
    /// </summary>
    [JsonPropertyName("sprite_path")]
    public required string SpritePath { get; set; }
}