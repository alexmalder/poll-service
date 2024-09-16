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
    public class InstanceController : CrudControllerBase<Instance, InstanceDTO>
    {
        public InstanceController(AppDbContext AppDbContext, IMapper mapper) : base(AppDbContext, mapper)
        {
        }
    }
    public class InstanceQuestionController : CrudControllerBase<InstanceQuestion, InstanceQuestionDTO>
    {
        public InstanceQuestionController(AppDbContext AppDbContext, IMapper mapper) : base(AppDbContext, mapper)
        {
        }
    }
    public class InstanceAnswerController : CrudControllerBase<InstanceAnswer, InstanceAnswerDTO>
    {
        public InstanceAnswerController(AppDbContext AppDbContext, IMapper mapper) : base(AppDbContext, mapper)
        {
        }
    }
}