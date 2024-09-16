using AutoMapper;

using DotNetCrudWebApi.Models;

namespace DotNetCrudWebApi.Config {
    public class MyAutoMapper: Profile
    {
        public MyAutoMapper()
        {
            CreateMap<QuestionDTO, Question>();
            CreateMap<AnswerDTO, Answer>();
            CreateMap<PollDTO, Poll>();
            CreateMap<PollInstanceDTO, PollInstance>();
            CreateMap<PollInstanceQuestionDTO, PollInstanceQuestion>();
            CreateMap<PollInstanceAnswerDTO, PollInstanceAnswer>();
        }
    }
}
