namespace urbancompany_salon.Models;

public class CartItem
{
    public int Id { get; set; }
    public int ServiceId { get; set; }
    public int Quantity { get; set; }
    public string UserId { get; set; }
    public SalonService? Service { get; set; } // Navigation property
}