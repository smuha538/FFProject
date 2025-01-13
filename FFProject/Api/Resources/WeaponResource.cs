using System.Text.Json.Serialization;
using Domain.Enums;

namespace Api.Resources;

/// <summary>
/// Weapon resource
/// </summary>
public class WeaponResource
{
    /// <summary>
    /// ID of the weapon
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the weapon
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    /// <summary>
    /// Type of the weapon
    /// </summary>
    [JsonPropertyName("type")]
    public required WeaponTypes Type { get; set; }
    
    /// <summary>
    /// Attack damage of the weapon
    /// </summary>
    [JsonPropertyName("attack")]
    public int? Attack { get; set; }
    
    /// <summary>
    /// Effect of the weapon
    /// </summary>
    [JsonPropertyName("effect")]
    public string Effect { get; set; } = string.Empty;
    
    /// <summary>
    /// Jobs that can use the weapon
    /// </summary>
    [JsonPropertyName("job")]
    public Jobs Job { get; set; }
    
    /// <summary>
    /// Accuracy of the weapon
    /// </summary>
    [JsonPropertyName("accuracy")]
    public int? Accuracy { get; set; }
    
    /// <summary>
    /// Critical damage of the weapon
    /// </summary>
    [JsonPropertyName("critical")]
    public int? Critical { get; set; }
    
    /// <summary>
    /// Sprite path of the weapon
    /// </summary>
    [JsonPropertyName("sprite_path")]
    public required string SpritePath { get; set; }
}