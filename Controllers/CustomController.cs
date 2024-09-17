using AutoMapper;
using DotNetCrudWebApi.Data;
using DotNetCrudWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrudWebApi.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class CustomController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        public CustomController(AppDbContext AppDbContext, IMapper mapper)
        {
            _appDbContext = AppDbContext;
            _mapper = mapper;
        }

        [HttpGet("RichSelect")]
        public async Task<IActionResult> RichList() {
            var entities = await _appDbContext.Instances
                .Include(c => c.InstanceQuestions)
                .ThenInclude(c => c.Question)
                .ToListAsync();
            return Ok(entities);
        }
    }
}