namespace Application.Models;

/// <summary>
/// Enemy model
/// </summary>
public class EnemyModel
{
    /// <summary>
    /// Enemy ID
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the enemy
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Hp of the enemy
    /// </summary>
    public int Hp { get; set; }
    
    /// <summary>
    /// Experience awarded for beating the enemy
    /// </summary>
    public int Experience { get; set; }
    
    /// <summary>
    /// Attack stat of the enemy
    /// </summary>
    public int Attack { get; set; }
    
    /// <summary>
    /// Defense stat of the enemy
    /// </summary>
    public int Defense { get; set; }
    
    /// <summary>
    /// Magic defense stat of the enemy
    /// </summary>
    public int MagicDefense { get; set; }
    
    /// <summary>
    /// Hit rate stat of the enemy
    /// </summary>
    public int Hit { get; set; }
    
    /// <summary>
    /// Sprite path of the item
    /// </summary>
    public required string SpritePath { get; set; }
}