using Domain.Enums;

namespace Application.Models;

/// <summary>
/// Weapon Model
/// </summary>
public class WeaponModel
{
    /// <summary>
    /// ID of the weapon
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the weapon
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Type of the weapon
    /// </summary>
    public required WeaponTypes Type { get; set; }
    
    /// <summary>
    /// Attack damage of the weapon
    /// </summary>
    public int? Attack { get; set; }
    
    /// <summary>
    /// Effect of the weapon
    /// </summary>
    public string Effect { get; set; } = string.Empty;
    
    /// <summary>
    /// Jobs that can use the weapon
    /// </summary>
    public Jobs Job { get; set; }
    
    /// <summary>
    /// Accuracy of the weapon
    /// </summary>
    public int? Accuracy { get; set; }
    
    /// <summary>
    /// Critical damage of the weapon
    /// </summary>
    public int? Critical { get; set; }
    
    /// <summary>
    /// Sprite path of the weapon
    /// </summary>
    public string SpritePath { get; set; } = string.Empty;
}