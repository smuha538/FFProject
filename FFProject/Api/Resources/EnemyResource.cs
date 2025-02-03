using System.Text.Json.Serialization;

namespace Api.Resources;

/// <summary>
/// Enemy resource
/// </summary>
public class EnemyResource
{
    /// <summary>
    /// Enemy ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the enemy
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    /// <summary>
    /// Hp of the enemy
    /// </summary>
    [JsonPropertyName("hp")]
    public int Hp { get; set; }
    
    /// <summary>
    /// Experience awarded for beating the enemy
    /// </summary>
    [JsonPropertyName("experience")]
    public int Experience { get; set; }
    
    /// <summary>
    /// Attack stat of the enemy
    /// </summary>
    [JsonPropertyName("attack")]
    public int Attack { get; set; }
    
    /// <summary>
    /// Defense stat of the enemy
    /// </summary>
    [JsonPropertyName("defense")]
    public int Defense { get; set; }
    
    /// <summary>
    /// Magic defense stat of the enemy
    /// </summary>
    [JsonPropertyName("magic_defense")]
    public int MagicDefense { get; set; }
    
    /// <summary>
    /// Hit rate stat of the enemy
    /// </summary>
    [JsonPropertyName("hit")]
    public int Hit { get; set; }
    
    /// <summary>
    /// Sprite path of the item
    /// </summary>
    [JsonPropertyName("sprite_path")]
    public required string SpritePath { get; set; }
}