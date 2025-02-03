
namespace Application.Models;

/// <summary>
/// UserItem model
/// </summary>
public class UserItemModel
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