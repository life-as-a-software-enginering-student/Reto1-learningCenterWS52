namespace _3_Data.Models;

public class DiscountCheckRequest
{
    public string MembershipStatus { get; set; }
    public string ShoeBrand { get; set; }
    public string ShoeSeason { get; set; }
    public bool IsFirstPurchase { get; set; }
}
