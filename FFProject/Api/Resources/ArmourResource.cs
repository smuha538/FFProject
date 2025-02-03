using System.Text.Json.Serialization;
using Domain.Enums;

namespace Api.Resources;

/// <summary>
/// Armour resource
/// </summary>
public class ArmourResource
{
    /// <summary>
    /// Armour ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the armour
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    /// <summary>
    /// Jobs that can use the armour
    /// </summary>
    [JsonPropertyName("job")]
    public Jobs Job { get; set; }
    
    /// <summary>
    /// Defense stat of the armour
    /// </summary>
    [JsonPropertyName("defense")]
    public int? Defense { get; set; }
    
    /// <summary>
    /// Evasion stat of the armour
    /// </summary>
    [JsonPropertyName("evasion")]
    public int? Evasion { get; set; }
    
    /// <summary>
    /// Path of the sprite
    /// </summary>
    [JsonPropertyName("sprite_path")]
    public required string SpritePath { get; set; }
}