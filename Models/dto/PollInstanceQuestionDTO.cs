using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCrudWebApi.Models
{
    public class PollInstanceQuestionDTO : DTOBase
    {
        [ForeignKey("QuestionId")]
        public long? QuestionId { get; set; }
        [ForeignKey("PollInstanceId")]
        public long? PollInstanceId { get; set; }
    }
}
