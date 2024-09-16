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
    public class AnswerController : CrudControllerBase<Answer, AnswerDTO>
    {
        public AnswerController(AppDbContext AppDbContext, IMapper mapper) : base(AppDbContext, mapper)
        {
        }
    }
    public class PollController : CrudControllerBase<Poll, PollDTO>
    {
        public PollController(AppDbContext AppDbContext, IMapper mapper) : base(AppDbContext, mapper)
        {
        }
    }
    public class PollInstanceController : CrudControllerBase<PollInstance, PollInstanceDTO>
    {
        public PollInstanceController(AppDbContext AppDbContext, IMapper mapper) : base(AppDbContext, mapper)
        {
        }
    }
    public class PollInstanceQuestionController : CrudControllerBase<PollInstanceQuestion, PollInstanceQuestionDTO>
    {
        public PollInstanceQuestionController(AppDbContext AppDbContext, IMapper mapper) : base(AppDbContext, mapper)
        {
        }
    }
    public class PollInstanceAnswerController : CrudControllerBase<PollInstanceAnswer, PollInstanceAnswerDTO>
    {
        public PollInstanceAnswerController(AppDbContext AppDbContext, IMapper mapper) : base(AppDbContext, mapper)
        {
        }
    }
}