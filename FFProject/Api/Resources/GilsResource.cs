using System.Text.Json.Serialization;

namespace Api.Resources;

/// <summary>
/// Gils resource
/// </summary>
public class GilsResource
{
    /// <summary>
    /// User ID
    /// </summary>
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
    
    /// <summary>
    /// Amount of gils
    /// </summary>
    [JsonPropertyName("amount")]
    public int Amount { get; set; }
}