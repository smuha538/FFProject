namespace Domain.Entities;

/// <summary>
/// User entity
/// </summary>
public class User
{
    /// <summary>
    /// ID of the user
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Username of the user
    /// </summary>
    public required string Username { get; set; }
    
    /// <summary>
    /// Password of the user
    /// </summary>
    public required string Password { get; set; }
    
    /// <summary>
    /// Email of the user
    /// </summary>
    public required string Email { get; set; }
}