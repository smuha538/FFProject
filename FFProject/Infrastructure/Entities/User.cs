using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase user entity
/// </summary>
[Table("Users")]
public class User: BaseModel
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
    public required string Username { get; set; }
    
    /// <summary>
    /// Password of the user
    /// </summary>
    [Column("password")]
    public required string Password { get; set; }
    
    /// <summary>
    /// Email of the user
    /// </summary>
    [Column("email")]
    public required string Email { get; set; }
}