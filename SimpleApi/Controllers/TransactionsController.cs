using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleApi.Data;
using SimpleApi.Models;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TransactionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetTransactions()
        {
            var transactions = await _context.Transactions.ToListAsync();
            var statuses = await _context.Statuses.ToListAsync();

            var response = new ApiResponse
            {
                Data = transactions,
                Status = statuses
            };

            return Ok(response);
        }
    }
}