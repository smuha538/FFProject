using System.Text.Json.Serialization;
namespace Api.Resources;

/// <summary>
/// Resource for a user
/// </summary>
public class UsersResource
{
    /// <summary>
    /// ID of a user 
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Username of a user
    /// </summary>
    [JsonPropertyName("username")]
    public required string Username { get; set; }
    
    /// <summary>
    /// Password of a user
    /// </summary>
    [JsonIgnore]
    public required string Password { get; set; }
    
    /// <summary>
    /// Email of a user
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }
}