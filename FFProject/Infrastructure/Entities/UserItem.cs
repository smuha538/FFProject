using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase userItem entity
/// </summary>
[Table("UserItems")]
public class UserItem: BaseModel
{
    /// <summary>
    /// User ID
    /// </summary>
    [PrimaryKey("user_id")]
    public int UserId { get; set; }
    
    /// <summary>
    /// Item ID
    /// </summary>
    [PrimaryKey("item_id")]
    public int ItemId { get; set; }
    
    /// <summary>
    /// Amount of item in possession
    /// </summary>
    [Column("amount")]
    public int Amount { get; set; }
}