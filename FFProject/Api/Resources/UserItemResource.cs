using System.Text.Json.Serialization;

namespace Api.Resources;

/// <summary>
/// UserItem resource
/// </summary>
public class UserItemResource
{
    /// <summary>
    /// User ID
    /// </summary>
    [JsonPropertyName("id")]
    public int UserId { get; set; }
    
    /// <summary>
    /// Item ID
    /// </summary>
    [JsonPropertyName("item_id")]
    public int ItemId { get; set; }
    
    /// <summary>
    /// Amount of item in possession
    /// </summary>
    [JsonPropertyName("amount")]
    public int Amount { get; set; }
}