namespace Domain.Entities;

/// <summary>
/// UserItem entity
/// </summary>
public class UserItem
{
    /// <summary>
    /// User ID
    /// </summary>
    public int UserId { get; set; }
    
    /// <summary>
    /// Item ID
    /// </summary>
    public int ItemId { get; set; }
    
    /// <summary>
    /// Amount of item in possession
    /// </summary>
    public int Amount { get; set; }
}