using System.Text.Json.Serialization;
using Domain.Enums;

namespace Api.Resources;

/// <summary>
/// Item resource
/// </summary>
public class ItemResource
{
    /// <summary>
    /// Item ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the item
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    /// <summary>
    /// Type of item
    /// </summary>
    [JsonPropertyName("item_type")]
    public ItemTypes ItemType { get; set; }
    
    /// <summary>
    /// Price of the item
    /// </summary>
    [JsonPropertyName("price")]
    public int Price { get; set; }
    
    /// <summary>
    /// Amount the item restores
    /// </summary>
    [JsonPropertyName("restore_amount")]
    public int? RestoreAmount { get; set; }
    
    /// <summary>
    /// Sprite path of the item
    /// </summary>
    [JsonPropertyName("sprite_path")]
    public required string SpritePath { get; set; }
}