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
            CreateMap<InstanceDTO, Instance>();
            CreateMap<InstanceQuestionDTO, InstanceQuestion>();
            CreateMap<InstanceAnswerDTO, InstanceAnswer>();
        }
    }
}
