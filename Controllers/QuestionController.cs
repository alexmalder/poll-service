using AutoMapper;
using DotNetCrudWebApi.Data;
using DotNetCrudWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrudWebApi.Controllers
{
    public class QuestionController : CrudControllerBase<Question, QuestionDTO>
    {
        public QuestionController(AppDbContext AppDbContext, IMapper mapper) : base(AppDbContext, mapper)
        {
        
        }
    }
}