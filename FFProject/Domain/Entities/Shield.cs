using Domain.Enums;

namespace Domain.Entities;

/// <summary>
/// Shield entity
/// </summary>
public class Shield
{
    /// <summary>
    /// Shield ID
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the shield
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Jobs that can use the shield
    /// </summary>
    public Jobs Job { get; set; }
    
    /// <summary>
    /// Defense stat of the shield
    /// </summary>
    public int Defense { get; set; }
    
    /// <summary>
    /// Evasion stat of the shield
    /// </summary>
    public int Evasion { get; set; }
    
    /// <summary>
    /// Sprite path of the shield
    /// </summary>
    public required string SpritePath { get; set; }
}