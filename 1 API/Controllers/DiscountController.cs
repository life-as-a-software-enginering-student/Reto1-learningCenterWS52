using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_Domain;
using _3_Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_API.Properties
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private DiscountChecker _discountChecker;

        public DiscountController(DiscountChecker discountChecker)
        {
            _discountChecker = discountChecker;
        }

        // POST: api/discount/check
        [HttpPost("check")]
        public DiscountCheckResponse Post([FromBody] DiscountCheckRequest request)
        {
            return _discountChecker.CheckDiscount(request);
        }


        // GET: api/membership/status
        [HttpGet("membership/status")]
        public IEnumerable<string> GetMembershipStatuses()
        {
            return new List<string> { "premium", "regular" };
        }

        // GET: /api/shoe/brands
        [HttpGet("shoe/brands")]
        public IEnumerable<string> GetShoeBrands()
        {
            return new List<string> { "Nike", "Adidas", "Reebok" };
        }

        // GET: api/shoe/seasons
        [HttpGet("shoe/seasons")]
        public IEnumerable<string> GetShoeSeasons()
        {
            return new List<string> { "current", "past" };
        }
    }
}