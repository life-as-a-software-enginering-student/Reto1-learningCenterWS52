using _3_Data;
using _3_Data.Models;

namespace _2_Domain;

public class DiscountCheckerDomain : IDiscountCheckerDomain
{
    private IDiscountCheckerDomain _discountCheckerDomain;
    public DiscountCheckerDomain(IDiscountCheckerDomain discountCheckerDomain)
    {
        _discountCheckerDomain = discountCheckerDomain;
    }

    public DiscountCheckResponse CheckDiscount(DiscountCheckRequest data)
    {
        DiscountCheckResponse response = new DiscountCheckResponse();

        decimal originalPrice = 150;
        decimal discountedPrice = originalPrice;

        if (data.MembershipStatus == "premium")
        {
            discountedPrice *= 0.85m;
        }

        if (data.ShoeBrand == "Nike" || data.ShoeBrand == "Adidas")
        {
            discountedPrice *= 0.90m;
        }

        if (data.ShoeSeason == "past")
        {
            discountedPrice *= 0.80m;
        }

        if (data.IsFirstPurchase)
        {
            discountedPrice *= 0.75m;
        }

        data.OriginalPrice = originalPrice;
        response.DiscountedPrice = discountedPrice;

        return response;
    }
}