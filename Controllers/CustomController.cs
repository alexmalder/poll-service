using AutoMapper;
using DotNetCrudWebApi.Repositories;
using DotNetCrudWebApi.Data;
using DotNetCrudWebApi.Models;
using LdapForNet;
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
        private readonly ILdapRepository _ldapRepository;
        public CustomController(AppDbContext AppDbContext, IMapper mapper, ILdapRepository ldapRepository)
        {
            _appDbContext = AppDbContext;
            _mapper = mapper;
            _ldapRepository = ldapRepository;
        }

        [HttpGet("InstancesWithQuestions")]
        public async Task<IActionResult> GetInstancesWithQuestions() {
            var entities = await _appDbContext.Instances
                .Include(c => c.InstanceQuestions)
                .ThenInclude(c => c.Question)
                .ToListAsync();
            return Ok(entities);
        }

        [HttpPost("SignIn")]
        public IActionResult LdapTest(SignInDTO signIn)
        {
            var ldapEntry = _ldapRepository.GetWhoAmI(signIn);
            return Ok(ldapEntry);
        }
    }
}