using AutoMapper;
using DotNetCrudWebApi.Data;
using DotNetCrudWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrudWebApi.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class PollMappingController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        public PollMappingController(AppDbContext AppDbContext, IMapper mapper)
        {
            _appDbContext = AppDbContext;
            _mapper = mapper;
        }

        [HttpGet("/Rich")]
        public async Task<IActionResult> RichList() {
            var entities = await _appDbContext.Set<Poll>().ToListAsync();
            return Ok(entities);
        }
    }
}