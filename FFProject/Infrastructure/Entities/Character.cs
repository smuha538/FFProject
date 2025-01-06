using Domain.Enums;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase character entity
/// </summary>
[Table("Characters")]
public class Character: BaseModel
{
    /// <summary>
    /// Character ID
    /// </summary>
    [PrimaryKey("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// User ID
    /// </summary>
    [Column("user_id")]
    public int UserId { get; set; }
    
    /// <summary>
    /// Name of the Character
    /// </summary>
    [Column("name")]
    public required string Name { get; set; }
    
    /// <summary>
    /// Defense stat of the Character
    /// </summary>
    [Column("def")]
    public int Defense { get; set; }
    
    /// <summary>
    /// Evasion stat of the Character
    /// </summary>
    [Column("eva")]
    public int Evasion { get; set; }
    
    /// <summary>
    /// Hp stat of the Character
    /// </summary>
    [Column("hp")]
    public int HitPoint { get; set; }
    
    /// <summary>
    /// Mp stat of the Character
    /// </summary>
    [Column("mp")]
    public int ManaPoint { get; set; }
    
    /// <summary>
    /// Strength stat of the Character
    /// </summary>
    [Column("str")]
    public int Strength { get; set; }
    
    /// <summary>
    /// Agile stat of the Character
    /// </summary>
    [Column("agl")]
    public int Agile { get; set; }
    
    /// <summary>
    /// Intelligence stat of the Character
    /// </summary>
    [Column("int")]
    public int Intelligence { get; set; }
    
    /// <summary>
    /// Stamina stat of the Character
    /// </summary>
    [Column("sta")]
    public int Stamina { get; set; }
    
    /// <summary>
    /// Luck stat of the Character
    /// </summary>
    [Column("lck")]
    public int Luck { get; set; }
    
    /// <summary>
    /// Attack stat of the Character
    /// </summary>
    [Column("atk")]
    public int Attack { get; set; }
    
    /// <summary>
    /// Accuracy stat of the Character
    /// </summary>
    [Column("acc")]
    public int Accuracy { get; set; }
    
    /// <summary>
    /// Magic Defense stat of the Character
    /// </summary>
    [Column("mdef")]
    public int MagicDefense { get; set; }
    
    /// <summary>
    /// Level stat of the Character
    /// </summary>
    [Column("level")]
    public int Level { get; set; }
    
    /// <summary>
    /// Current Experience stat of the Character
    /// </summary>
    [Column("current_exp")]
    public int CurrentExperience { get; set; }
    
    /// <summary>
    /// Experience needed to level up the Character
    /// </summary>
    [Column("next_level")]
    public int NextLevel { get; set; }
    
    /// <summary>
    /// Job of the Character
    /// </summary>
    [Column("job")]
    public Jobs Job { get; set; }
}