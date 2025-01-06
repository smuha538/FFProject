using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase characterEquipment entity
/// </summary>
[Table("CharacterEquipment")]
public class CharacterEquipment: BaseModel
{
    /// <summary>
    /// User ID
    /// </summary>
    [PrimaryKey("user_id")]
    public int UserId { get; set; }
    
    /// <summary>
    /// Character ID
    /// </summary>
    [Column("character_id")]
    public int CharacterId { get; set; }
    
    /// <summary>
    /// Weapon ID
    /// </summary>
    [Column("weapon_id")]
    public int WeaponId { get; set; }
    
    /// <summary>
    /// Armour ID
    /// </summary>
    [Column("armour_id")]
    public int ArmourId { get; set; }
    
    /// <summary>
    /// Shield ID
    /// </summary>
    [Column("shield_id")]
    public int ShieldId { get; set; }
    
    /// <summary>
    /// Accessory ID
    /// </summary>
    [Column("accessory_id")]
    public int AccessoryId { get; set; }
}