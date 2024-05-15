using _3_Data;
using _3_Data.Models;

namespace _2_Domain;

public class DiscountChecker
{
    public DiscountCheckResponse CheckDiscount(DiscountCheckRequest request)
        {
            var response = new DiscountCheckResponse();
            decimal originalPrice = 150; 
            decimal discountedPrice = originalPrice;

            if (request.MembershipStatus == "premium")
            {
                discountedPrice *= 0.85m;
            }

            if (request.ShoeBrand == "Nike" || request.ShoeBrand == "Adidas")
            {
                discountedPrice *= 0.90m;
            }

            if (request.ShoeSeason == "past")
            {
                discountedPrice *= 0.80m;
            }

            if (request.IsFirstPurchase)
            {
                discountedPrice *= 0.75m;
            }

            response.OriginalPrice = originalPrice;
            response.DiscountedPrice = discountedPrice;

            return response;
        }
}