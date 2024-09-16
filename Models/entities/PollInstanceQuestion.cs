using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DotNetCrudWebApi.Models
{
    public class PollInstanceQuestion : EntityBase
    {
        public Question? Question;
        public PollInstance? PollInstance;

        [ForeignKey("QuestionId")]
        public long? AnswerId { get; set; }
        
        [ForeignKey("PollInstanceId")]
        public long? PollInstanceId { get; set; }
    }
}
