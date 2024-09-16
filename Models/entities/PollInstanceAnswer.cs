using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DotNetCrudWebApi.Models
{
    public class PollInstanceAnswer : EntityBase
    {
        public Answer? Answer;
        public PollInstance? PollInstance;

        [ForeignKey("AnswerId")]
        public long? AnswerId { get; set; }
        
        [ForeignKey("PollInstanceId")]
        public long? PollInstanceId { get; set; }
    }
}
