using _3_Data.Models;

namespace _3_Data;

public interface IDiscountCheck
{
    List<DiscountCheckRequest> GetMembershipStatus();
    
    List<DiscountCheckRequest> GetShoeBrand();
    
    List<DiscountCheckRequest> GetShoeSeasons();
    
    /*DiscountCheckResponse  DiscountCheckResponse(DiscountCheckRequest data);
    
    /*DiscountCheckRequest GetById(int id);
    
    bool Save(DiscountCheckRequest data);
    
    bool Update(DiscountCheckRequest data, int id);
    
    bool Delete(int id);*/
    
}