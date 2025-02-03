﻿using System.Text.Json.Serialization;
using Domain.Enums;

namespace Api.Resources;

/// <summary>
/// Shield Resource
/// </summary>
public class ShieldResource
{
    /// <summary>
    /// Shield ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the shield
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    /// <summary>
    /// Jobs that can use the shield
    /// </summary>
    [JsonPropertyName("job")]
    public Jobs Job { get; set; }
    
    /// <summary>
    /// Defense stat of the shield
    /// </summary>
    [JsonPropertyName("defense")]
    public int? Defense { get; set; }
    
    /// <summary>
    /// Evasion stat of the shield
    /// </summary>
    [JsonPropertyName("evasion")]
    public int? Evasion { get; set; }
    
    /// <summary>
    /// Sprite path of the shield
    /// </summary>
    [JsonPropertyName("sprite_path")]
    public string SpritePath { get; set; } = string.Empty;
}