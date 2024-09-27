using AutoMapper;
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
        public CustomController(AppDbContext AppDbContext, IMapper mapper)
        {
            _appDbContext = AppDbContext;
            _mapper = mapper;
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
        public async Task<IActionResult> LdapTest(SignInDTO signIn) {
            using (var cn = new LdapConnection())
            {
                // connect use hostname and port
                cn.Connect(new Uri("ldap://localhost:1389"));
                cn.Bind(LdapForNet.Native.Native.LdapAuthMechanism.SIMPLE, string.Format("cn={0},ou=users,dc=example,dc=ru", signIn.Username), signIn.Password);
                var entries = cn.Search("dc=example,dc=ru","(objectClass=*)");
                return Ok(entries);
            }
        }
    }
}