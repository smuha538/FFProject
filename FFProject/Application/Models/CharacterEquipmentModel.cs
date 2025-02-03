namespace Application.Models;

/// <summary>
/// CharacterEquipment model
/// </summary>
public class CharacterEquipmentModel
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
    /// Weapon ID
    /// </summary>
    public int WeaponId { get; set; }
    
    /// <summary>
    /// Armour ID
    /// </summary>
    public int ArmourId { get; set; }
    
    /// <summary>
    /// Shield ID
    /// </summary>
    public int ShieldId { get; set; }
    
    /// <summary>
    /// Accessory ID
    /// </summary>
    public int AccessoryId { get; set; }
}