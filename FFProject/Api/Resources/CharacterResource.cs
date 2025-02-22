﻿using System.Text.Json.Serialization;
using Domain.Enums;

namespace Api.Resources;

/// <summary>
/// Character resource
/// </summary>
public class CharacterResource
{
    /// <summary>
    /// Character ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// User ID
    /// </summary>
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
    
    /// <summary>
    /// Name of the Character
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    /// <summary>
    /// Defense stat of the Character
    /// </summary>
    [JsonPropertyName("defense")]
    public int Defense { get; set; }
    
    /// <summary>
    /// Evasion stat of the Character
    /// </summary>
    [JsonPropertyName("evasion")]
    public int Evasion { get; set; }
    
    /// <summary>
    /// Hp stat of the Character
    /// </summary>
    [JsonPropertyName("hp")]
    public int HitPoint { get; set; }
    
    /// <summary>
    /// Mp stat of the Character
    /// </summary>
    [JsonPropertyName("mp")]
    public int ManaPoint { get; set; }
    
    /// <summary>
    /// Strength stat of the Character
    /// </summary>
    [JsonPropertyName("strength")]
    public int Strength { get; set; }
    
    /// <summary>
    /// Agile stat of the Character
    /// </summary>
    [JsonPropertyName("agile")]
    public int Agile { get; set; }
    
    /// <summary>
    /// Intelligence stat of the Character
    /// </summary>
    [JsonPropertyName("intelligence")]
    public int Intelligence { get; set; }
    
    /// <summary>
    /// Stamina stat of the Character
    /// </summary>
    [JsonPropertyName("stamina")]
    public int Stamina { get; set; }
    
    /// <summary>
    /// Luck stat of the Character
    /// </summary>
    [JsonPropertyName("luck")]
    public int Luck { get; set; }
    
    /// <summary>
    /// Attack stat of the Character
    /// </summary>
    [JsonPropertyName("attack")]
    public int Attack { get; set; }
    
    /// <summary>
    /// Accuracy stat of the Character
    /// </summary>
    [JsonPropertyName("accuracy")]
    public int Accuracy { get; set; }
    
    /// <summary>
    /// Magic Defense stat of the Character
    /// </summary>
    [JsonPropertyName("magic_defense")]
    public int MagicDefense { get; set; }
    
    /// <summary>
    /// Level stat of the Character
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; set; }
    
    /// <summary>
    /// Current Experience stat of the Character
    /// </summary>
    [JsonPropertyName("current_experience")]
    public int CurrentExperience { get; set; }
    
    /// <summary>
    /// Experience needed to level up the Character
    /// </summary>
    [JsonPropertyName("next_level")]
    public int NextLevel { get; set; }
    
    /// <summary>
    /// Job of the Character
    /// </summary>
    [JsonPropertyName("job")]
    public Jobs Job { get; set; }
}