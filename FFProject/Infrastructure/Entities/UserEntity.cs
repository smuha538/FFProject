using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase user entity
/// </summary>
[Table("Users")]
public class UserEntity: BaseModel
{
    /// <summary>
    /// ID of the user
    /// </summary>
    [PrimaryKey("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Username of the user
    /// </summary>
    [Column("username")]
    public string Username { get; set; } = string.Empty;
    
    /// <summary>
    /// Password of the user
    /// </summary>
    [Column("password")]
    public string Password { get; set; } = string.Empty;
    
    /// <summary>
    /// Email of the user
    /// </summary>
    [Column("email")]
    public string Email { get; set; } = string.Empty;
}