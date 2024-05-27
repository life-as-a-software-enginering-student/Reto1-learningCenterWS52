using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_Domain;
using _3_Data;
using _3_Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private IDiscountCheckerDomain _discountCheckerDomain;
        private IDiscountCheck _discountCheckRequest;

        public DiscountController(IDiscountCheckerDomain discountCheckerDomain, IDiscountCheck discountCheckRequest)
        {
            _discountCheckerDomain = discountCheckerDomain;
            _discountCheckRequest = discountCheckRequest;
        }


        // POST: api/discount/check
        [HttpPost("check")]
        public DiscountCheckResponse Post([FromBody] DiscountCheckRequest request)
        {
            return _discountCheckerDomain.CheckDiscount(request);
        }


        // GET: api/membership/status
        [HttpGet("membership/status")]
        public IEnumerable<DiscountCheckRequest> GetMembershipStatuses()
        {
            return _discountCheckRequest.GetMembershipStatus();
        }

        // GET: /api/shoe/brands
        [HttpGet("shoe/brands")]
        public IEnumerable<DiscountCheckRequest> GetShoeBrands()
        {
            return _discountCheckRequest.GetShoeBrand();
        }

        // GET: api/shoe/seasons
        [HttpGet("shoe/seasons")]
        public IEnumerable<DiscountCheckRequest> GetShoeSeasons()
        {
            return _discountCheckRequest.GetShoeSeasons();
        }
    }
}