using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Infrastructure.Entities;

/// <summary>
/// Supabase gils entity
/// </summary>
[Table("Gils")]
public class GilsEntity: BaseModel
{
    /// <summary>
    /// User ID
    /// </summary>
    [PrimaryKey("user_id")]
    public int UserId { get; set; }
    
    /// <summary>
    /// Amount of gils
    /// </summary>
    [Column("amount")]
    public int Amount { get; set; }
}