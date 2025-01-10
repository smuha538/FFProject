namespace Application.Models;

/// <summary>
/// User model
/// </summary>
public class UserModel
{
    /// <summary>
    /// ID of a user 
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Username of a user
    /// </summary>
    public required string Username { get; set; }
    
    /// <summary>
    /// Password of a user
    /// </summary>
    public string Password { get; set; }
    
    /// <summary>
    /// Email of a user
    /// </summary>
    public required string Email { get; set; }
}