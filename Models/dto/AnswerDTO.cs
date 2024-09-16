namespace DotNetCrudWebApi.Models
{
    public class AnswerDTO : DTOBase
    {
        public string? Title { get; set; }
        public long? QuestionId { get; set; }
    }
}
