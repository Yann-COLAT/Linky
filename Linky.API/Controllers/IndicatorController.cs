using Linky.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Linky.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndicatorController : ControllerBase
    {
        protected readonly LinkyContext _context;
        public IndicatorController(LinkyContext context)
        {
            _context = context;    
        }

        [HttpPost(nameof(CreateIndicator))]
        public Indicator CreateIndicator(Indicator indicator) 
        {
            var create = _context.Add(indicator).Entity;
            _context.SaveChanges();
            return create;
        }
    }
}
