using System.Text.Json.Serialization;

namespace Api.Resources;

/// <summary>
/// CharacterEquipment resource
/// </summary>
public class CharacterEquipmentResource
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
    /// Weapon ID
    /// </summary>
    [JsonPropertyName("weapon_id")]
    public int WeaponId { get; set; }
    
    /// <summary>
    /// Armour ID
    /// </summary>
    [JsonPropertyName("armour_id")]
    public int ArmourId { get; set; }
    
    /// <summary>
    /// Shield ID
    /// </summary>
    [JsonPropertyName("shield_id")]
    public int ShieldId { get; set; }
    
    /// <summary>
    /// Accessory ID
    /// </summary>
    [JsonPropertyName("accessory_id")]
    public int AccessoryId { get; set; }
}