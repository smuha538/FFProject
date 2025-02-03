using Domain.Enums;

namespace Application.Models;

/// <summary>
/// Item model
/// </summary>
public class ItemModel
{
    /// <summary>
    /// Item ID
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the item
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Type of item
    /// </summary>
    public ItemTypes ItemType { get; set; }
    
    /// <summary>
    /// Price of the item
    /// </summary>
    public int Price { get; set; }
    
    /// <summary>
    /// Amount the item restores
    /// </summary>
    public int? RestoreAmount { get; set; }
    
    /// <summary>
    /// Sprite path of the item
    /// </summary>
    public required string SpritePath { get; set; }
}