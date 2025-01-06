namespace Domain.Entities;

/// <summary>
/// Accessory entity
/// </summary>
public class Accessory
{
    /// <summary>
    /// Accessory ID
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the Accessory
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Defense stat of the Accessory
    /// </summary>
    public int Defense { get; set; }
    
    /// <summary>
    /// Evasion stat of the Accessory
    /// </summary>
    public int Evasion { get; set; }
    
    /// <summary>
    /// Path of the sprite
    /// </summary>
    public required string SpritePath { get; set; }
}