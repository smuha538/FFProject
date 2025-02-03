using Domain.Enums;

namespace Application.Models;

/// <summary>
/// Character model
/// </summary>
public class CharacterModel
{
    /// <summary>
    /// Character ID
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// User ID
    /// </summary>
    public int UserId { get; set; }
    
    /// <summary>
    /// Name of the Character
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Defense stat of the Character
    /// </summary>
    public int Defense { get; set; }
    
    /// <summary>
    /// Evasion stat of the Character
    /// </summary>
    public int Evasion { get; set; }
    
    /// <summary>
    /// Hp stat of the Character
    /// </summary>
    public int HitPoint { get; set; }
    
    /// <summary>
    /// Mp stat of the Character
    /// </summary>
    public int ManaPoint { get; set; }
    
    /// <summary>
    /// Strength stat of the Character
    /// </summary>
    public int Strength { get; set; }
    
    /// <summary>
    /// Agile stat of the Character
    /// </summary>
    public int Agile { get; set; }
    
    /// <summary>
    /// Intelligence stat of the Character
    /// </summary>
    public int Intelligence { get; set; }
    
    /// <summary>
    /// Stamina stat of the Character
    /// </summary>
    public int Stamina { get; set; }
    
    /// <summary>
    /// Luck stat of the Character
    /// </summary>
    public int Luck { get; set; }
    
    /// <summary>
    /// Attack stat of the Character
    /// </summary>
    public int Attack { get; set; }
    
    /// <summary>
    /// Accuracy stat of the Character
    /// </summary>
    public int Accuracy { get; set; }
    
    /// <summary>
    /// Magic Defense stat of the Character
    /// </summary>
    public int MagicDefense { get; set; }
    
    /// <summary>
    /// Level stat of the Character
    /// </summary>
    public int Level { get; set; }
    
    /// <summary>
    /// Current Experience stat of the Character
    /// </summary>
    public int CurrentExperience { get; set; }
    
    /// <summary>
    /// Experience needed to level up the Character
    /// </summary>
    public int NextLevel { get; set; }
    
    /// <summary>
    /// Job of the Character
    /// </summary>
    public Jobs Job { get; set; }
}