using _3_Data.Models;

namespace _3_Data;

public class DiscountCheck :IDiscountCheck
{
    //Lista de datos de prueba
    public List<DiscountCheckRequest> GetMembershipStatus()
    {
        List<DiscountCheckRequest> data = new List<DiscountCheckRequest>();
        data.Add(new DiscountCheckRequest { MembershipStatus = "Premium" });
        data.Add(new DiscountCheckRequest { MembershipStatus = "Free"});

        return data;
    }

    public List<DiscountCheckRequest> GetShoeBrand()
    {
        List<DiscountCheckRequest> data = new List<DiscountCheckRequest>();
        data.Add(new DiscountCheckRequest { ShoeBrand = "Nike" });
        data.Add(new DiscountCheckRequest { ShoeBrand = "Adidas"});
        data.Add(new DiscountCheckRequest { ShoeBrand = "Reebok"});

        return data;
    }
    
    public List<DiscountCheckRequest> GetShoeSeasons()
    {
        List<DiscountCheckRequest> data = new List<DiscountCheckRequest>();
        data.Add(new DiscountCheckRequest { MembershipStatus = "current" });
        data.Add(new DiscountCheckRequest { MembershipStatus = "past"});

        return data;
    }
    
}