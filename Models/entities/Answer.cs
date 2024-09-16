using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCrudWebApi.Models
{
    public class Answer : EntityBase
    {
        public string? Title { get; set; }
        [ForeignKey("Question")]
        public long? QuestionId { get; set; }
        //public Question Question { get; set; } = null!;
    }
}
