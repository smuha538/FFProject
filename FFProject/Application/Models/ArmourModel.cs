using Domain.Enums;

namespace Application.Models;

/// <summary>
/// Armour model
/// </summary>
public class ArmourModel
{
    /// <summary>
    /// Armour ID
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the armour
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Jobs that can use the armour
    /// </summary>
    public Jobs Job { get; set; }
    
    /// <summary>
    /// Defense stat of the armour
    /// </summary>
    public int? Defense { get; set; }
    
    /// <summary>
    /// Evasion stat of the armour
    /// </summary>
    public int? Evasion { get; set; }
    
    /// <summary>
    /// Path of the sprite
    /// </summary>
    public required string SpritePath { get; set; }
}