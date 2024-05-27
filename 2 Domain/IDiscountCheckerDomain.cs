using _3_Data;
using _3_Data.Models;

namespace _2_Domain;

public interface IDiscountCheckerDomain
{
    DiscountCheckResponse CheckDiscount(DiscountCheckRequest data);
    
}